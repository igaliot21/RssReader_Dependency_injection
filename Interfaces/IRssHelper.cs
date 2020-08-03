using RssReader.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.Interfaces
{
    public interface IRssHelper
    {
        List<Item> GetPost();
    }
}