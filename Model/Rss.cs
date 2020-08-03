using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RssReader.Model
{
	[XmlRoot(ElementName = "rss")]
	public class Rss
	{
		[XmlElement(ElementName = "channel")]
		public Channel Channel { get; set; }
		[XmlAttribute(AttributeName = "version")]
		public string Version { get; set; }
	}

	[XmlRoot(ElementName = "channel")]
	public class Channel
	{
		[XmlElement(ElementName = "title")]
		public string Title { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "link")]
		public string Link { get; set; }
		[XmlElement(ElementName = "category")]
		public Category Category { get; set; }
		[XmlElement(ElementName = "copyright")]
		public string Copyright { get; set; }
		[XmlElement(ElementName = "docs")]
		public string Docs { get; set; }
		[XmlElement(ElementName = "language")]
		public string Language { get; set; }
		[XmlElement(ElementName = "lastBuildDate")]
		public string LastBuildDate { get; set; }
		[XmlElement(ElementName = "managingEditor")]
		public string ManagingEditor { get; set; }
		[XmlElement(ElementName = "pubDate")]
		public string PubDate { get; set; }
		[XmlElement(ElementName = "webMaster")]
		public string WebMaster { get; set; }
		[XmlElement(ElementName = "generator")]
		public string Generator { get; set; }
		[XmlElement(ElementName = "image")]
		public Image Image { get; set; }
		[XmlElement(ElementName = "item")]
		public List<Item> Item { get; set; }
	}

	[XmlRoot(ElementName = "category")]
	public class Category
	{
		[XmlAttribute(AttributeName = "domain")]
		public string Domain { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "image")]
	public class Image
	{
		[XmlElement(ElementName = "url")]
		public string Url { get; set; }
		[XmlElement(ElementName = "title")]
		public string Title { get; set; }
		[XmlElement(ElementName = "link")]
		public string Link { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "width")]
		public string Width { get; set; }
		[XmlElement(ElementName = "height")]
		public string Height { get; set; }
	}

	[XmlRoot(ElementName = "item")]
	public class Item
	{
		[XmlElement(ElementName = "title")]
		public string Title { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "link")]
		public string Link { get; set; }
		[XmlElement(ElementName = "pubDate")]
		public string PubDate { get; set; }
	}
}
