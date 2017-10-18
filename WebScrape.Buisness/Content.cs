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
        public string GetContent(string url)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(url);
            HtmlNode[] nodes = document.DocumentNode.SelectNodes("//a[@href]").ToArray();
            string resault=string.Empty;
            foreach (HtmlNode link in nodes)
            {
                string hrefValue = link.GetAttributeValue("href", string.Empty);
                if (hrefValue != "#")
                {
                    resault += hrefValue + Environment.NewLine;
                }
            }
            return resault;
        }
    }
}
