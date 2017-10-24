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
                
                var urlTree = new UrlTree();
                List<string> result = await Task.Run(() => urlTree.GetUrls(url));
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

        public void PopulateTree(List<string> urls)
        {
            //Set tree to 'loading' state
            UrlTreeView.Nodes.Clear();

            //Task<TreeNode[]> t = Task<TreeNode[]>.Factory.StartNew(() => PopulateTreeNodes(urls));
            //t.ContinueWith(x => UpdateUI(x.Result), TaskScheduler.FromCurrentSynchronizationContext());

            TreeNode[] treeNodes = PopulateTreeNodes(urls);
            UpdateUI(treeNodes);
        }

        private TreeNode[] PopulateTreeNodes(List<string> urls)
        {
            //var subUrls = GetSubcategories(urls);
            //IList<TreeNode> treeNodes = await urls.Select(GetSubcategories).ToList();
            List<TreeNode> treeNodes = new List<TreeNode>(urls.Count);

            foreach(string url in urls)
            {
                treeNodes.Add(new TreeNode(url));
            }

            return treeNodes.ToArray();
        }

        private async Task<List<TreeNode>> GetSubcategories(string url)
        {
            var node = new TreeNode();
            var urlTree = new UrlTree();
            List<string> result = await Task.Run(() => urlTree.GetUrls(url));
            List<TreeNode> treenodeResult = new List<TreeNode>();

            for (int i = 0; i < result.Count; i++)
            {
                treenodeResult.Add(new TreeNode(result[i]));
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
