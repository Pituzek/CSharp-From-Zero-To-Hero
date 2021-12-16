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
        }

        private string city;

        [JsonProperty("City")]
        public string City
        {
            get { return this.city; }
        }

        private string street;

        [JsonProperty("Street")]
        public string Street
        {
            get { return this.street; }
        }

        private string item;

        [JsonProperty("Item")]
        public string Item
        {
            get { return this.item; }
        }

        private DateTime time;

        [JsonProperty("DateTime")]
        public DateTime Time
        {
            get { return this.time;}
        }

        private decimal price;

        [JsonProperty("Price")]
        public decimal Price
        {
            get { return this.price; }
        }

        //private List<Transactions> transactionList = new List<Transactions>();
        //public List<Transactions> TransactionList
        //{
        //    get { return this.transactionList; }
        //    //set { this.transactionList = value; }
        //}

        [JsonConstructor]
        public Transactions(string Shop, string City, string Street, string Item, string DateTime,  string Price)
        {
            this.shop = Shop;
            this.city = City;
            this.street = Street;
            this.item = Item;

            CultureInfo culture = new CultureInfo("en-US");
            DateTime tempDate = Convert.ToDateTime(DateTime, culture);
            this.time = tempDate;

            bool ok = decimal.TryParse(Price, out decimal result);
            this.price = ok ? result : -1;

            //AddTransaction(this);
        }


        //public void AddTransaction(Transactions items)
        //{
        //    TransactionList.Add(items);
        //}

        public override string ToString()
        {
            return string.Format($"Name: {shop}\n City: {city}\n Street: {street}\n Item: {item}\n Time: {time}\n Price: {price}\n\n");
        }
    }
}
