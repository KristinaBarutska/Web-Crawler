using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebScrape.Buisness
{
    public class Content
    {
        public List<string> GetContent(string baseUrl)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(baseUrl);
            HtmlNode[] nodes = document.DocumentNode.SelectNodes("//a[@href]").ToArray();
            List<string> resault = new List<string>();
            foreach (HtmlNode link in nodes)
            {
                string hrefValue = link.GetAttributeValue("href", string.Empty);
                if (hrefValue != "#")
                {
                    resault.Add(GetAbsoluteUrlString(baseUrl, hrefValue) + Environment.NewLine);
                }
            }
            return resault;
        }

        private static string GetAbsoluteUrlString(string baseUrl, string url)
        {
            var uri = new Uri(url, UriKind.RelativeOrAbsolute);
            if (!uri.IsAbsoluteUri)
                uri = new Uri(new Uri(baseUrl), uri);
            return uri.ToString();
        }
    }
}
