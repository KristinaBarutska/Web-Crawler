using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Threading;

namespace WebScrape.Buisness
{
    public class UrlTree
    {

        public List<string> CrawlUrls(string baseUrl)
        {
            
            if (!Uri.IsWellFormedUriString(baseUrl, UriKind.Absolute))
            {
                throw new System.InvalidOperationException("Please enter a valid URL");
            }
            else
            {
                HtmlWeb web = new HtmlWeb();
                HtmlDocument document = web.Load(baseUrl);
                HtmlNode[] nodes = document.DocumentNode.SelectNodes("//a[@href]").ToArray();
                List<string> urlList = new List<string>();

                foreach (HtmlNode link in nodes)
                {
                    string hrefValue = link.GetAttributeValue("href", string.Empty);
                    if (hrefValue != null && hrefValue != String.Empty)
                    {
                        if (hrefValue != "#" && !hrefValue.Contains(baseUrl) && hrefValue[0] != '/')
                        {
                            urlList.Add(GetAbsoluteUrlString(baseUrl, hrefValue) + Environment.NewLine);
                        }
                    }
                }
                Thread.Sleep(3000);
                return urlList;
            }

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
