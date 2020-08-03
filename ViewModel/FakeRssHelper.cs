using RssReader.Interfaces;
using RssReader.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.ViewModel
{
    public class FakeRssHelper : IRssHelper
    {
        public List<Item> GetPost()
        {
            List<Item> posts = new List<Item>();

            posts.Add(new Item() { 
                Title = "Titulo 1",
                Description = "Descripción 1",
                PubDate = "Thu, 22 Nov 2018 06:13:30 GMT"
            });
            posts.Add(new Item()
            {
                Title = "Titulo 2",
                Description = "Descripción 2",
                PubDate = "Thu, 22 Nov 2018 08:00:30 GMT"
            });

            return posts;
        }
    }
}
