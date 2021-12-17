using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Newtonsoft.Json;

namespace BootCamp.Chapter
{
    public class Transactions
    {
        //Shop,City,Street,Item,DateTime,Price
        private string shop;

        [JsonProperty("Shop")]
        public string Shop
        {
            get { return this.shop; }
            set { this.shop = value; }
        }

        private string city;

        [JsonProperty("City")]
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        private string street;

        [JsonProperty("Street")]
        public string Street
        {
            get { return this.street; }
            set { this.Street = value; }
        }

        private string item;

        [JsonProperty("Item")]
        public string Item
        {
            get { return this.item; }
            set { this.item = value; }
        }

        private DateTime time;

        [JsonProperty("DateTime")]
        public DateTime Time
        {
            get { return this.time;}
            set { this.time = value; }
        }

        private decimal priceDec;

        public decimal PriceDec
        {
            get { return this.priceDec; }
        }

        [JsonProperty("Price")]
        public string Price { get; set; }

        public Transactions(string shop, string City, string Street, string Item, string DateTime, string Price)
        {
            this.shop = shop;
            this.city = City;
            this.street = Street;
            this.item = Item;

            CultureInfo culture = new CultureInfo("en-US");
            DateTime tempDate = Convert.ToDateTime(DateTime, culture);
            this.time = tempDate;

            bool ok = decimal.TryParse(Price, out decimal result);
            this.priceDec = ok ? result : -1;

            this.Price = Price;

            //AddTransaction(this);
        }

        //public void AddTransaction(Transactions items)
        //{
        //    TransactionList.Add(items);
        //}

        public override string ToString()
        {
            return string.Format($"Name: {shop}\n City: {city}\n Street: {street}\n Item: {item}\n Time: {time}\n Price: {priceDec}\n PriceString: {Price}\n");
        }
    }
}
