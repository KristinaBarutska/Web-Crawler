using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrape.Buisness;

namespace WebScrape
{

    public partial class TreeViewUserControl : UserControl
    {
        private NodeBuilder nodeBuilder;
        private int levels;
        private HashSet<Url> uniqueLinks;

        public TreeViewUserControl(HashSet<Url>uniqueLinks)
        {
            InitializeComponent();
            this.uniqueLinks = uniqueLinks;
            nodeBuilder = new NodeBuilder();           
            ProgressBar.Style = ProgressBarStyle.Marquee;
            ProgressBar.Visible = false;
        }

        public async void submitButton_Click(object sender, EventArgs e)
        {
            uniqueLinks.Clear();

            if (WithErrors())
            {
                errorLabel.Text = "Please enter valid url and levels";
            }

            else
            {
                ProgressBar.Visible = true;
                try
                {
                    string url = UrlTextBox.Text;
                    levels = int.Parse(levelsTextBox.Text);

                    UrlTreeView.Nodes.Clear();
                    nodeBuilder.Clear();

                    TreeNode mainTreeNode = new TreeNode(url);
                    UrlTreeView.Nodes.Add(mainTreeNode);


                    await BuildTree(mainTreeNode, await Task.Run(() => nodeBuilder.GetListUrls(url)), 0, levels);

                    ProgressBar.Visible = false;

                }

                catch (System.InvalidOperationException ex)
                {
                    errorLabel.Text = ex.Message;
                }

                catch (System.ArgumentException ex)
                {
                    errorLabel.Text = ex.Message;
                }
            }
        }

        private async Task BuildTree(TreeNode mainTreeNode, List<Url> urls, int currentLevel, int maxLevel)
        {
            if (currentLevel >= maxLevel)
                return;

            foreach (Url url in urls)
            {

                if (!uniqueLinks.Select(x => x.Name).Contains(url.Name))
                {
                    url.Count++;
                    uniqueLinks.Add(url);
                    TreeNode childNode = new TreeNode(url.Name);
                    mainTreeNode.Nodes.Add(childNode);
                    List<Url> childUrls = await Task.Run(() => nodeBuilder.GetListUrls(url.Name));
                    await BuildTree(childNode, childUrls, currentLevel + 1, maxLevel);
                }
                else
                {
                    Url selectedUrl = uniqueLinks.Where(x => x.Name == url.Name).SingleOrDefault();
                    uniqueLinks.Remove(selectedUrl);
                    selectedUrl.Count++;
                    uniqueLinks.Add(selectedUrl);
                }

            }
        }

        private bool WithErrors()
        {
            if (UrlTextBox.Text.Trim() == String.Empty)
                return true;
            if (levelsTextBox.Text.Trim() == String.Empty)
                return true;
            int num;

            if (!int.TryParse(levelsTextBox.Text.Trim(), out num))
            {
                return true;
            }
            else
            {
                if (num < 1 || num > 3)
                {
                    return true;
                }
            }

            return false;
        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
