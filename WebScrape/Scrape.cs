using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrape.Buisness;


namespace WebScrape
{
    public partial class Scrape : Form
    {
        public Scrape()
        {
            InitializeComponent();
            
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {

            try
            {
                string url = UrlTextBox.Text;
                int levels = int.Parse(levelsTextBox.Text);
                var urlTree = new UrlTree();
                List<Url> result = await Task.Run(() => urlTree.GetUrls(url));
                PopulateTree(result);

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

        public void PopulateTree(List<Url> urls)
        {

            UrlTreeView.Nodes.Clear();

            TreeNode[] treeNodes = PopulateTreeNodes(urls);
            UpdateUI(treeNodes);
        }

        private TreeNode[] PopulateTreeNodes(List<Url> urls)
        {

            List<TreeNode> treeNodes = new List<TreeNode>(urls.Count);

            foreach(Url url in urls)
            {
                treeNodes.Add(new TreeNode(url.Name));
            }

            return treeNodes.ToArray();
        }

        private async Task<List<TreeNode>> GetLinks(string url)
        {
            var node = new TreeNode();
            var urlTree = new UrlTree();
            List<Url> result = await Task.Run(() => urlTree.GetUrls(url));
            List<TreeNode> treenodeResult = new List<TreeNode>();

            for (int i = 0; i < result.Count; i++)
            {
                treenodeResult.Add(new TreeNode(result[i].Name));
            }

            return treenodeResult;
        }

        private void UpdateUI(TreeNode[] nodes)
        {
            UrlTreeView.Nodes.Clear();

            UrlTreeView.Nodes.AddRange(nodes);
        }

    }
}
