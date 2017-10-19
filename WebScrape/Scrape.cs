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
            try
            {
                var resault = content.GetContent(url);
                List<TreeNode> treeNodeList = new List<TreeNode>();
                foreach (var item in resault)
                {
                    TreeNode childNode = new TreeNode(item);
                    treeNodeList.Add(childNode);
                }
                TreeNode treeNode = new TreeNode(url, treeNodeList.ToArray());
                UrlTreeView.Nodes.Add(treeNode);
            }
            catch(System.InvalidOperationException ex)
            {
                errorLabel.Text = ex.Message;
            }
                      
            
        }
        
    }
}
