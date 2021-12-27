using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BootCamp.Chapter.Xml
{
	[XmlRoot(ElementName = "Transactions")]
	public class Transactions
	{

		[XmlElement(ElementName = "Transaction")]
		public List<Transaction> Transaction { get; set; }
	}
}
