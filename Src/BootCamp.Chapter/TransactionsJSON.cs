using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BootCamp.Chapter
{
    class TransactionsJSON
    {
        public string Shop { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string Item { get; set; }

        public DateTime DateTime { get; set; }

        public string Price { get; set; }
    }
}
