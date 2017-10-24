using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrape.Buisness;
using System.Threading.Tasks;

namespace WebScrape
{
    public partial class Scrape : Form
    {
        public Scrape()
        {
            InitializeComponent();
            
        }

        //private async void submitButton_Click(object sender, EventArgs e)
        //{
            
        //    try
        //    {
        //        string url = UrlTextBox.Text;
        //        var urlTree = new UrlTree();

        //        List<string> resault = await Task.Run(() => urlTree.CrawlUrls(url)); ;
        //        List<TreeNode> treeNodeList = new List<TreeNode>();
        //        foreach (var item in resault)
        //        {
        //            TreeNode childNode = new TreeNode(item);
        //            treeNodeList.Add(childNode);
        //        }
        //        TreeNode treeNode = new TreeNode(url, treeNodeList.ToArray());
        //        UrlTreeView.Nodes.Add(treeNode);
        //    }

        //    catch(System.InvalidOperationException ex)
        //    {
        //        errorLabel.Text = ex.Message;
        //    }
                      
        //    catch(System.ArgumentException ex)
        //    {
        //        errorLabel.Text = ex.Message;
        //    }
        //}

        private async void submitButton_Click(object sender, EventArgs e)
        {

            try
            {
                string url = UrlTextBox.Text;
                
                var urlTree = new UrlTree();
                List<string> resault = await Task.Run(() => urlTree.CrawlUrls(url));
                PopulateTree(resault);
                //List<TreeNode> treeNodeList = new List<TreeNode>();
                //foreach (var item in resault)
                //{
                //    TreeNode childNode = new TreeNode(item);
                //    treeNodeList.Add(childNode);
                //}
                //TreeNode treeNode = new TreeNode(url, treeNodeList.ToArray());
                //UrlTreeView.Nodes.Add(treeNode);
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
            UrlTreeView.Nodes.Add("Loading...");


            Task<TreeNode[]> t = Task<TreeNode[]>.Factory.StartNew(() => PopulateTreeNodes(urls));
            t.ContinueWith(x => UpdateUI(x.Result), TaskScheduler.FromCurrentSynchronizationContext());
        }

        private static TreeNode[] PopulateTreeNodes(List<string> urls)
        {
            IList<TreeNode> treeNodes = urls.Select(GetSubcategories).ToList();

            return treeNodes.ToArray();
        }

        private static TreeNode GetSubcategories(string url)
        {
    
            //int numberOfSubcategories = category.Id < 5 ? category.Id : category.Id % 5;


            TreeNode node = new TreeNode(url);
            for (int i = 0; i < 5; i++)
            {
                TreeNode childNode = new TreeNode("ChildNode" + url + "_" + i);
                node.Nodes.Add(childNode);
            }

            return node;
        }

        private void UpdateUI(TreeNode[] nodes)
        {
            //Clear out previous 'Loading...' node
            UrlTreeView.Nodes.Clear();

            //Populate with new list of nodes, like a boss
            UrlTreeView.Nodes.AddRange(nodes);
        }

    }
}
