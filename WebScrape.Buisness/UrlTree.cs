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

        public List<Url> GetUrls(string baseUrl)
        {
          
            baseUrl = baseUrl.Trim(new char[] { '\r', '\n' });

            List<Url> urlList = new List<Url>();
            HashSet<string> LinksHashSet = new HashSet<string>();

            Uri tempUrlObj = null;
            if (
                Uri.IsWellFormedUriString(baseUrl, UriKind.Absolute) &&
                (System.Uri.TryCreate(baseUrl, UriKind.Absolute, out tempUrlObj) &&
                (tempUrlObj.Scheme == Uri.UriSchemeHttp|| tempUrlObj.Scheme == Uri.UriSchemeHttps))
                )
            {
                HtmlWeb web = new HtmlWeb();
                try
                {
                    HtmlDocument document = web.Load(baseUrl);
                    if (web.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        return urlList;
                    }

                    HtmlNode[] nodes = document.DocumentNode.SelectNodes("//a[@href]")?.ToArray();

                    if (nodes == null)
                    {
                        return urlList;
                    }

                    foreach (HtmlNode link in nodes)
                    {

                        string hrefValue = link.GetAttributeValue("href", string.Empty);
                        if (hrefValue != null && hrefValue != String.Empty)
                        {
                            if (hrefValue != "#" && !hrefValue.Contains(baseUrl) && hrefValue[0] != '/')
                            {
                                Url currentUrl = new Url();
                                currentUrl.Name = GetAbsoluteUrlString(baseUrl, hrefValue) + Environment.NewLine;
                                if (!LinksHashSet.Contains(currentUrl.Name))
                                {
                                    LinksHashSet.Add(currentUrl.Name);
                                    urlList.Add(currentUrl);
                                }
                                //urlList.Add(GetAbsoluteUrlString(baseUrl, hrefValue) + Environment.NewLine);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // TODO: maybe log the exception
                    return urlList;
                }
            }
            return urlList;
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
