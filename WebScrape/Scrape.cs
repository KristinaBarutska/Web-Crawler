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

        public async void PopulateTree(List<Url> urls)
        {

            UrlTreeView.Nodes.Clear();
            TreeNode root = new TreeNode();
            root.Text = "My url";
            root.Tag = null;
            //TreeNode[] treeNodes = PopulateTreeNodes(urls);
            await Task.Run(() => PopulateTreeNodes1(ref root, urls, 0));
            
            UpdateUI1(root);
            return;
        }

        //private TreeNode[] PopulateTreeNodes(List<Url> urls)
        //{

        //    List<TreeNode> treeNodes = new List<TreeNode>(urls.Count);

        //    foreach (Url url in urls)
        //    {
        //        treeNodes.Add(new TreeNode(url.Name));
        //    }

        //    return treeNodes.ToArray();
        //}

        public void PopulateTreeNodes1(ref TreeNode root, List<Url> urls, int level)
        {
            if (level <= 1) // use constant instead
            {
                foreach (var url in urls)
                {
                    var child = new TreeNode()
                    {
                        Text = url.Name,
                    };

                    var urlTree = new UrlTree();
                    var childUrlObjects = urlTree.GetUrls(url.Name);
                    PopulateTreeNodes1(ref child, childUrlObjects, level + 1);
                    root.Nodes.Add(child);
                }
            }

            return;
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

        private void UpdateUI1(TreeNode nodes)
        {
            UrlTreeView.Nodes.Clear();

            UrlTreeView.Nodes.Add(nodes);
        }

    }
}
