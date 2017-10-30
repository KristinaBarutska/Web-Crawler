using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrape.Buisness;

namespace WebScrape
{
    public class UrlTreeBuilder
    {
        private HashSet<Url> uniqueUrls;
        private string initialUrl;
        int levels;

        public UrlTreeBuilder(string initialUrl, int levels)
        {
            this.initialUrl = initialUrl;
            this.levels = levels;
        }

        public async Task<TreeNode> BuildTree()
        {
            var urlTree = new UrlTree();
            List<Url> result = await Task.Run(() => urlTree.GetUrls(initialUrl));
            TreeNode root = new TreeNode();

            await Task.Run(() => PopulateTreeNodes(ref root, result.Distinct().ToList(), 0));

            return root;
        }
        

        private void PopulateTreeNodes(ref TreeNode root, List<Url> urls, int level)
        {
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
                    // filter the collection according to the contents of uniqueUrls

                    PopulateTreeNodes(ref child, childUrlObjects, level + 1);
                    root.Nodes.Add(child);
                }
            }

            return;
        }
    }
}
