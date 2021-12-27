using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BootCamp.Chapter.Xml
{
	[XmlRoot(ElementName = "Transaction")]
	public class Transaction
	{

		[XmlElement(ElementName = "Shop")]
		public string Shop { get; set; }

		[XmlElement(ElementName = "City")]
		public string City { get; set; }

		[XmlElement(ElementName = "Street")]
		public string Street { get; set; }

		[XmlElement(ElementName = "Item")]
		public string Item { get; set; }

		[XmlElement(ElementName = "DateTime")]
		public DateTime DateTime { get; set; }

		[XmlElement(ElementName = "Price")]
		public string Price { get; set; }
	}
}
