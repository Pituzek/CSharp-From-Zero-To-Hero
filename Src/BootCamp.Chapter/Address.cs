using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Address
    {
        public string Recipient { get; }
        public string Street { get; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HouseNumber { get; set; }

        public Address(string recipient, string street, string town, string county, string postalCode, string country, string houseNumber = "")
        {
            this.Recipient = recipient;
            this.Street = street;
            this.Town = town;
            this.County = county;
            this.PostalCode = postalCode;
            this.Country = country;
            this.HouseNumber = houseNumber;
        }

        public static bool TryParse(string addressString, out Address address)
        {
            address = default;
            return false;
        }

        public static bool operator ==(Address adress1, Address adress2)
        {
            bool isEqual = (
                adress1.Recipient == adress2.Recipient &&
                adress1.Street == adress2.Street &&
                adress1.Town == adress2.Town &&
                adress1.County == adress2.County &&
                adress1.PostalCode == adress2.PostalCode &&
                adress1.Country == adress2.Country &&
                adress1.HouseNumber == adress2.HouseNumber
                );
            return isEqual;
        }

        public static bool operator !=(Address adress1, Address adress2)
        {
            bool isEqual = (
              adress1.Recipient != adress2.Recipient &&
              adress1.Street != adress2.Street &&
              adress1.Town != adress2.Town &&
              adress1.County != adress2.County &&
              adress1.PostalCode != adress2.PostalCode &&
              adress1.Country != adress2.Country &&
              adress1.HouseNumber != adress2.HouseNumber
              );
            return (isEqual);
        }
    }
}
