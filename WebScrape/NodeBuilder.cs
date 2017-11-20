using System.Collections.Generic;
using WebScrape.Buisness;

namespace WebScrape
{
    public class NodeBuilder
    {
        private Crawler crawler;
        private HashSet<string> uniqueUrls;

        public NodeBuilder()
        {
            crawler = new Crawler();
            uniqueUrls = new HashSet<string>();
        }

        public void Clear()
        {
            uniqueUrls.Clear();
        }

        public List<Url> GetListUrls(string url)
        {
            return crawler.GetUrls(url);
        }
    }
}
