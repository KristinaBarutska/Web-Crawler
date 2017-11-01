using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrape.Buisness;


namespace WebScrape
{
    public partial class Scrape : Form
    {
        private NodeBuilder nodeBuilder;
        private int levels;
        private HashSet<Url> uniqueLinks = new HashSet<Url>();
        public Scrape()
        {
            InitializeComponent();

            nodeBuilder = new NodeBuilder();
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            if (WithErrors())
            {
                errorLabel.Text = "Please enter valid url and levels";
            }

            else
            {
                try
                {
                    string url = UrlTextBox.Text;
                    levels = int.Parse(levelsTextBox.Text);

                    UrlTreeView.Nodes.Clear();
                    nodeBuilder.Clear();

                    TreeNode mainTreeNode = new TreeNode(url);
                    UrlTreeView.Nodes.Add(mainTreeNode);

                    BuildTree(mainTreeNode, await Task.Run(() => nodeBuilder.GetListUrls(url)), 0, levels);

                    errorLabel.Text = "Display completed!";
                    
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

        private async void BuildTree(TreeNode mainTreeNode, List<Url> urls, int currentLevel, int maxLevel)
        {
            if (currentLevel >= maxLevel)
                return;

            foreach (Url url in urls)
            {
                
                if (!uniqueLinks.Select(x=>x.Name).Contains(url.Name))
                {
                    url.Count++;
                    uniqueLinks.Add(url);
                    TreeNode childNode = new TreeNode(url.Name);
                    mainTreeNode.Nodes.Add(childNode);
                    List<Url> childUrls = await Task.Run(() => nodeBuilder.GetListUrls(url.Name));
                    BuildTree(childNode, childUrls, currentLevel + 1, maxLevel);
                }
                else
                {
                    Url selectedUrl=uniqueLinks.Where(x => x.Name == url.Name).SingleOrDefault();
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

        private void ShowStatisticsButton_Click(object sender, EventArgs e)
        {
            var links = uniqueLinks.ToList();
            var bindingList = new BindingList<Url>(links);
            var source = new BindingSource(bindingList, null);
            statisticDataGridView.DataSource = source;
            //var source = new BindingSource();
            //source.DataSource = links;
            //statisticDataGridView.DataSource = source;
        }
    }
}
