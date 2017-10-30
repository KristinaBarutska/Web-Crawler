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

        private bool WithErrors()
        {
            if (UrlTextBox.Text.Trim() == String.Empty)
                return true; 
            if (levelsTextBox.Text.Trim() == String.Empty )
                return true;

            return false;
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            if (WithErrors())
            {
                errorLabel.Text = "Please enter valid url and levels";
            }

            else
            {
                //if(int.TryParse(levelsTextBox.Text.Trim,out int resault)){

                //}
                try
                {
                    string url = UrlTextBox.Text;
                    int levels = int.Parse(levelsTextBox.Text);
                    var urlTree = new UrlTree();

                    UrlTreeView.Nodes.Clear();
                    // root.Text = UrlTextBox.Text; //?

                    UrlTreeBuilder tb = new UrlTreeBuilder(url, levels);
                    var rootNode = await tb.BuildTree();
                    rootNode.Text = UrlTextBox.Text;
                    //List<Url> result = await Task.Run(() => urlTree.GetUrls(url));
                    //PopulateTree(result);


                    UpdateUI(rootNode);

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

        public async void PopulateTree(List<Url> urls)
        {
            int levels = int.Parse(levelsTextBox.Text);
            UrlTreeView.Nodes.Clear();
            TreeNode root = new TreeNode();
            root.Text = UrlTextBox.Text;

            await Task.Run(() => PopulateTreeNodes(ref root, urls, 0));
            
            UpdateUI(root);
            return;
        }


        public void PopulateTreeNodes(ref TreeNode root, List<Url> urls, int level)
        {
            int levels = int.Parse(levelsTextBox.Text);
            if (level < levels) 
            {
                foreach (var url in urls)
                {
                    var child = new TreeNode()
                    {
                        Text = url.Name,
                    };

                    var urlTree = new UrlTree();
                    var childUrlObjects = urlTree.GetUrls(url.Name);
                    PopulateTreeNodes(ref child, childUrlObjects, level + 1);
                    root.Nodes.Add(child);
                }
            }

            return;
        }
        
        private void UpdateUI(TreeNode node)
        {
            UrlTreeView.Nodes.Clear();

            UrlTreeView.Nodes.Add(node);
        }

        private void levelsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
