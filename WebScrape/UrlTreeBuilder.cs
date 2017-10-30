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
        private HashSet<string> uniqueUrls= new HashSet<string>();
        private string initialUrl;
        int levels;

        public UrlTreeBuilder(string initialUrl, int levels)
        {
            this.initialUrl = initialUrl;
            this.levels = levels;            
        }

        public async Task<TreeNode> BuildTree()
        {
            var crawler = new Crawler();
            List<Url> result = await Task.Run(() => crawler.GetUrls(initialUrl));
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

                    Crawler urlTree = new Crawler();
                    List<Url> childUrlObjects = urlTree.GetUrls(url.Name);
                    var childUlrUniqueList = new List<Url>();
                    //filter the collection according to the contents of uniqueUrls
                    foreach (var childObject in childUrlObjects)
                    {
                        if (!uniqueUrls.Contains(childObject.Name))
                        {
                            uniqueUrls.Add(childObject.Name);
                            childUlrUniqueList.Add(childObject);
                        }
                    }

                    PopulateTreeNodes(ref child, childUlrUniqueList, level + 1);
                    root.Nodes.Add(child);
                }
            }
            return;
        }
    }
}
