using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///     Import data from .txt file
            /// </summary>
            List<string> adressData = ReadDataFromFile.GetData();

            ///<summary>
            ///     Create address object
            /// </summary>
            CreateAddressObjectFromImportedData.CreateObject(adressData);

            ///<summary>
            ///     Group data by post office
            /// </summary>
            var fullList = Address.AddressList;
            var groupedByPostal = fullList.GroupBy(x => x.PostalCode).ToList();

            ///<summary>
            ///     Find and count duplicates for every post office
            /// </summary>
            int equalCount = 0;
            int highestDuplicatesCount = int.MinValue;
            string? postalOfficeWithMostDuplicates = string.Empty;
            string? currentPostOffice = string.Empty;

            for (int i = 0; i < groupedByPostal.Count; i++)
            {
                var list = groupedByPostal[i].ToList();
                currentPostOffice = list[0]?.PostalCode;

                for (int j = 1; j < list.Count; j++)
                {
                    var isEqual = list[0] == list[j];
                    if (isEqual) equalCount++;
                }

                if (equalCount > highestDuplicatesCount)
                {
                    highestDuplicatesCount = equalCount;
                    postalOfficeWithMostDuplicates = currentPostOffice;
                }
                equalCount = 0;
            }

            //Console.WriteLine($"{postalOfficeWithMostDuplicates} - {highestDuplicatesCount}");
        }
    }
}
