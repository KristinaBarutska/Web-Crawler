using System;
using System.Collections.Generic;
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
                    //progressBar.Minimum = 0;
                    //progressBar.Maximum = 5;
                    //progressBar.Step = 1;
                    //progressBar.Value = 0;
                    

                    //UrlTreeView.Nodes.Clear();

                    //async Task ShowTaskbar()
                    //{
                    //    await Task.Run(() =>
                    //    {
                    //        for (int i = 1; i <= 5; i++)
                    //        {
                    //            System.Threading.Thread.Sleep(2000);
                    //            Invoke(new Action(() => progressBar.PerformStep()));
                    //        }
                    //    });
                    //}

                    //await ShowTaskbar();

                    string url = UrlTextBox.Text;
                    levels = int.Parse(levelsTextBox.Text);

                    UrlTreeView.Nodes.Clear();
                    nodeBuilder.Clear();

                    TreeNode mainTreeNode = new TreeNode(url);
                    UrlTreeView.Nodes.Add(mainTreeNode);

                    BuildTree(mainTreeNode, await Task.Run(() => nodeBuilder.GetListUrls(url)), 0, levels);

                    //UrlTreeBuilder tb = new UrlTreeBuilder(url, levels);
                    //TreeNode rootNode;                                       

                    //rootNode = await tb.BuildTree();
                    //rootNode.Text = UrlTextBox.Text;

                    //UrlTreeView.Nodes.Add(rootNode);                    
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
                TreeNode childNode = new TreeNode(url.Name);
                mainTreeNode.Nodes.Add(childNode);

                List<Url> childUrls = await Task.Run(() => nodeBuilder.GetListUrls(url.Name));
                BuildTree(childNode, childUrls, currentLevel + 1, maxLevel);
            }
        }

        private bool WithErrors()
        {
            if (UrlTextBox.Text.Trim() == String.Empty)
            {
                return true;
            }
            if (levelsTextBox.Text.Trim() == String.Empty)
            {
                return true;
            }

            int num;

            if(!int.TryParse(levelsTextBox.Text.Trim(), out num))
            {
                return true;                
            }
            else
            {
                if ( num > 3|| num<1)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
