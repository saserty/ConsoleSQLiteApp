using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace BestRSSever
{
    public class RssReader
    {
        public IEnumerable<Post> ReadFeed(string url)
        {
            var rssFeed = XDocument.Load(url);

            var posts = from item in rssFeed.Descendants("item")
                        select new Post
                        {
                            Title = item.Element("title").Value,
                            Description = item.Element("description").Value.Replace("<br>", "\n").Replace("&amp;", "&").Replace("&quot;", "'").Replace("&lt;", "<").Replace("&gt;", ">"),
                            PublishedDate = item.Element("pubDate").Value,
                            Link = item.Element("link").Value
                        };           
            
            return posts;
        }

        //public Post LambdaReplacement(XElement item)
        //{
        //    return new Post
        //                {
        //                    Title = item.Element("title").Value,
        //                    Description = item.Element("description").Value,
        //                    PublishedDate = item.Element("pubDate").Value,
        //                    Link = item.Element("link").Value
        //                };
        //}
    }
}
