using RssReader.Interfaces;
using RssReader.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RssReader.ViewModel
{
    public class RssHelper : IRssHelper
    {
        public List<Item> GetPost() {
            List<Item> posts = new List<Item>();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Rss));
            using (WebClient client = new WebClient()) {
                string xml = Encoding.Default.GetString(client.DownloadData("https://www.feedforall.com/sample-feed.xml"));
                
                using (var reader = new MemoryStream(Encoding.UTF8.GetBytes(xml))) {
                    Rss blog = (Rss)xmlSerializer.Deserialize(reader);
                    posts = blog.Channel.Item;
                }
            }

            return posts;
        }
    }
}
