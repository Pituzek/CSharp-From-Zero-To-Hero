using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> adressData = ReadDataFromFile.GetData();

            for (int i = 0; i < adressData.Count; i++)
            {
                List<string> singleCity = new List<string>();
                singleCity.Add(adressData[i]);

                if (singleCity.Count == 7) new Address(singleCity[0], singleCity[1], singleCity[2], singleCity[3], singleCity[4], singleCity[5], singleCity[6]);    
            }

            Address adress1 = new Address(adressData[0], adressData[1], adressData[2], adressData[3], adressData[4], adressData[5], adressData[6]);
            Address adress2 = new Address(adressData[7], adressData[1], adressData[2], adressData[3], adressData[4], adressData[5], adressData[6]);

            var isDuplicate = adress1 == adress2;
            Console.WriteLine(isDuplicate);

        }
    }
}
