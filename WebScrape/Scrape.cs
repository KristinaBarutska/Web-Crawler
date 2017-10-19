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

namespace WebScrape
{
    public partial class Scrape : Form
    {
        public Scrape()
        {
            InitializeComponent();
            
        }

        private void UrlTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string url = UrlTextBox.Text;
            var content = new Content();
            var resault = content.GetContent(url);
            //resaultLabel.Text = resault;
                      
            List<TreeNode> treeNodeList = new List<TreeNode>();
            foreach (var item in resault)
            {
                TreeNode childNode = new TreeNode(item);
                treeNodeList.Add(childNode);                
            }
            TreeNode treeNode = new TreeNode(url, treeNodeList.ToArray());
            UrlTreeView.Nodes.Add(treeNode);
        }

        private void Scrape_Load(object sender, EventArgs e)
        {
            //// This is the first node in the view.
            ////
            //TreeNode treeNode = new TreeNode("Windows");
            //UrlTreeView.Nodes.Add(treeNode);
            ////
            //// Another node following the first node.
            ////
            //treeNode = new TreeNode("Linux");
            //UrlTreeView.Nodes.Add(treeNode);
            ////
            //// Create two child nodes and put them in an array.
            //// ... Add the third node, and specify these as its children.
            ////
            //TreeNode node2 = new TreeNode("C#");
            //TreeNode node3 = new TreeNode("VB.NET");
            //TreeNode[] array = new TreeNode[] { node2, node3 };
            ////
            //// Final node.
            ////
            //treeNode = new TreeNode("Dot Net Perls", array);
            //UrlTreeView.Nodes.Add(treeNode);
        }
    }
}
