using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    class FilterByItemMoney
    {
        public static void FindCityNameMinMax(ImportTransactionsData dataInput, List<string> command, string outputFilePath, string fileExtension)
        {
            if (command[1] == "items" || command[1] == "money")
            {
                ///<summary>>
                ///     prepare data for evaluation
                /// </summary>
                if (fileExtension != ".xml")
                {
                    FindMinMaxByCity.GroupDataByCity(dataInput.Data);
                }
                else
                {
                    FindMinMaxByCity.GroupDataByCity(dataInput.DataXml);
                }

                ///<summary>
                ///     search for min or max
                /// </summary>            
                switch (command[2])
                {
                    case "min":
                        if (command[1] == "items")
                        {
                            var cityNameWithLowestItemCount = FindMinMaxByCity.FindCityItemsMin(City.CityList);
                            ExportDataToReport.PrintMinMaxReport(cityNameWithLowestItemCount, Path.Combine(outputFilePath), fileExtension); //"CityItemsMin.csv"
                        }
                        else
                        {
                            var cityNameWithLowestMoneyCount = FindMinMaxByCity.FindCityMoneyMin(City.CityList);
                            ExportDataToReport.PrintMinMaxReport(cityNameWithLowestMoneyCount, Path.Combine(outputFilePath), fileExtension); //"CityMoneyMin.csv"
                        }
                        break;
                    case "max":
                        if (command[1] == "items")
                        {
                            var cityNameWithMaxItemCount = FindMinMaxByCity.FindCityItemsMax(City.CityList);
                            ExportDataToReport.PrintMinMaxReport(cityNameWithMaxItemCount, Path.Combine(outputFilePath), fileExtension); //"CityItemsMax.csv"
                        }
                        else
                        {
                            var cityNameWithMaxMoneyCount = FindMinMaxByCity.FindCityMoneyMax(City.CityList);
                            ExportDataToReport.PrintMinMaxReport(cityNameWithMaxMoneyCount, Path.Combine(outputFilePath), fileExtension); //"CityMoneyMax.csv"
                        }
                        break;
                }
            }
        }
    }
}
