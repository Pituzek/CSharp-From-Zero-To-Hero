using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class CreateAddressObjectFromImportedData
    {
        public static void CreateObject(List<string> adressData)
        {
            List<string> singleCity = new List<string>();
            int counter = 0;

            for (int i = 0; i < adressData.Count; i++)
            {
                if (adressData[i] != "")
                {
                    singleCity.Add(adressData[i]);
                    counter++;
                }

                if (counter == 7)
                {
                    new Address(singleCity[0], singleCity[1], singleCity[2], singleCity[3], singleCity[4], singleCity[5], singleCity[6]);
                    singleCity.Clear();
                    counter = 0;
                }
            }
        }
    }
}
