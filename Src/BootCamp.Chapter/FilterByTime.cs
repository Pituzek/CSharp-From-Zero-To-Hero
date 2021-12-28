using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BootCamp.Chapter;
using Newtonsoft.Json;

namespace BootCamp.Chapter
{
    public static class FilterByTime
    {
        public static void FilterByTimeHourRange(ImportTransactionsData dataInput, List<string> command, string outputFilePath, string fileExtension)
        {
            ///<summary>
            ///     Data filtered by hour range
            /// </summary>
            if (command.Count > 1 && command[0].ToLowerInvariant() == "time")
            {
                DateTime startTime = Convert.ToDateTime(command[1]);
                DateTime endTime = Convert.ToDateTime(command[2]);
                if (endTime.Hour == 0) endTime = endTime.AddDays(1.0d);

                var dataGroupedByHourRange = TimeLinq.GroupByHourRange(dataInput.Data, startTime, endTime);
                var getTotalPriceByHourRange = TimeLinq.GetTotalPriceByHour(dataGroupedByHourRange);
                var getItemCountByHourRange = TimeLinq.GetItemCountByHour(dataGroupedByHourRange);

                ///<summary>
                ///     Get average money earn, by dividing total price by item count
                /// </summary>
                List<string> avgMoneyPerHour = new List<string>();
                TimeLinq.GetAverageMoney(getTotalPriceByHourRange, getItemCountByHourRange, avgMoneyPerHour);

                ///<summary> 
                ///     Get rush hour
                /// </summary>
                List<string> rushHourDataSave = new List<string>();
                TimeLinq.GetRushHour(avgMoneyPerHour, rushHourDataSave);

                ///<summary>
                ///     Prepare collected data to export
                /// </summary>
                List<List<string>> fullDayReportData = new List<List<string>>();
                // add start/end time to print correct hour into report!!
                TimeLinq.FullDayReportData(getTotalPriceByHourRange, getItemCountByHourRange, avgMoneyPerHour, rushHourDataSave, fullDayReportData);

                bool isJson = fileExtension.Equals(".json");
                bool isXml = fileExtension.Equals(".xml");

                ///<summary>
                ///     Export to .json
                /// </summary>
                if (isJson)
                {
                    TimesToExport objList = new TimesToExport(startTime, endTime);
                    List<string> rushHourDataSaveJson = new List<string>();
                    TimeLinq.GetRushHourInt(avgMoneyPerHour, rushHourDataSaveJson);
                    var rushHour = rushHourDataSaveJson[0];
                    var rushHourInt = Convert.ToInt32(rushHour);

                    for (int i = 0; i < dataGroupedByHourRange.Count; i++)
                    {
                        for (int j = 0; j < objList.Times.Count; j++)
                        {
                            if (objList.Times[j].Hour == dataGroupedByHourRange[i].Key)
                            {
                                objList.Times[j].Count = getItemCountByHourRange[i];
                                objList.Times[j].Earned = "€" + avgMoneyPerHour[i];
                                if (rushHourInt == i) objList.RushHour = dataGroupedByHourRange[i].Key;
                            }
                        }
                    }

                    string[] removeExt = outputFilePath.Split(".");
                    string fileName = removeExt[0];
                    var jsonString = JsonConvert.SerializeObject(objList);
                    jsonString = JsonConvert.SerializeObject(objList, Formatting.Indented);
                    File.WriteAllText(fileName, jsonString);
                }
                ///<summary>
                ///     Export to .xml
                /// </summary>
                else if (isXml)
                {

                }
                ///<summary>
                ///     Export to .csv
                /// </summary>
                else
                {
                    ///<summary>
                    ///     Export data to FullDayRange.csv
                    /// </summary>
                    //var curDir = @"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Output";
                    var curDir = "";
                    ExportDataToReport.PrintTimeReport(fullDayReportData, Path.Combine(curDir, outputFilePath), "FullDayRange.csv");
                }
            }
        }
    
        public static void FilterByTimeFullDay(ImportTransactionsData dataInput, List<string> command, string outputFilePath, string fileExtension)
        {
            ///<summary>
            ///     Full day data without time filter
            /// </summary>
            if (command.Count == 1 && command[0].ToLowerInvariant() == "time")
            {
                List<System.Linq.IGrouping<int, Transactions>> dataGroupedByHour = new List<System.Linq.IGrouping<int, Transactions>>();
                List<decimal> getTotalPriceByHour = new List<decimal>();
                List<int> getItemCountByHour = new List<int>();
                List<System.Linq.IGrouping<int, BootCamp.Chapter.Xml.Transaction>> dataGroupedByHourXML = new List<System.Linq.IGrouping<int, BootCamp.Chapter.Xml.Transaction>>();
                List<decimal> getTotalPriceByHourXML = new List<decimal>();
                List<int> getItemCountByHourXML = new List<int>();

                if (fileExtension.Equals(".xml"))
                { 
                    dataGroupedByHourXML = TimeLinq.GroupByHour(dataInput.DataXml);
                    getTotalPriceByHourXML = TimeLinq.GetTotalPriceByHourXML(dataGroupedByHourXML);
                    getItemCountByHourXML = TimeLinq.GetItemCountByHourXML(dataGroupedByHourXML);
                    getTotalPriceByHour = getTotalPriceByHourXML;
                    getItemCountByHour = getItemCountByHourXML;
                }
                else
                {
                    dataGroupedByHour = TimeLinq.GroupByHour(dataInput.Data);
                    getTotalPriceByHour = TimeLinq.GetTotalPriceByHour(dataGroupedByHour);
                    getItemCountByHour = TimeLinq.GetItemCountByHour(dataGroupedByHour);
                }

                ///<summary>
                ///     Get average money earn, by dividing total price by item count
                /// </summary>
                List<string> avgMoneyPerHour = new List<string>();
                TimeLinq.GetAverageMoney(getTotalPriceByHour, getItemCountByHour, avgMoneyPerHour);

                ///<summary> 
                ///     Get rush hour
                /// </summary>
                List<string> rushHourDataSave = new List<string>();
                TimeLinq.GetRushHour(avgMoneyPerHour, rushHourDataSave);

                ///<summary>
                ///     Prepare collected data to export
                /// </summary>
                List<List<string>> fullDayReportData = new List<List<string>>();
                TimeLinq.FullDayReportData(getTotalPriceByHour, getItemCountByHour, avgMoneyPerHour, rushHourDataSave, fullDayReportData);

                bool isJson = fileExtension.Equals(".json");
                bool isXml = fileExtension.Equals(".xml");

                ///<summary>
                ///     Export to .json
                /// </summary>
                if (isJson)
                {
                    TimesToExport objList = new TimesToExport();
                    List<string> rushHourDataSaveJson = new List<string>();
                    TimeLinq.GetRushHourInt(avgMoneyPerHour, rushHourDataSaveJson);
                    var rushHour = rushHourDataSaveJson[0];
                    var rushHourInt = Convert.ToInt32(rushHour);

                    for (int i = 0; i < dataGroupedByHour.Count; i++)
                    {
                        for (int j = 0; j < objList.Times.Count; j++)
                        {
                            if (objList.Times[j].Hour == dataGroupedByHour[i].Key)
                            {
                                objList.Times[j].Count = getItemCountByHour[i];
                                objList.Times[j].Earned = "€" + avgMoneyPerHour[i];
                                if (rushHourInt == i) objList.RushHour = dataGroupedByHour[i].Key;
                            }
                        }
                    }

                    string[] removeExt = outputFilePath.Split(".");
                    string fileName = removeExt[0];
                    var jsonString = JsonConvert.SerializeObject(objList);
                    jsonString = JsonConvert.SerializeObject(objList, Formatting.Indented);
                    File.WriteAllText(fileName, jsonString);
                }

                ///<summary>
                ///     Export to .xml
                /// </summary>
                else if (isXml)
                {
                    TimesToExport objList = new TimesToExport();
                    List<string> rushHourDataSaveJson = new List<string>();
                    TimeLinq.GetRushHourInt(avgMoneyPerHour, rushHourDataSaveJson);
                    var rushHour = rushHourDataSaveJson[0];
                    var rushHourInt = Convert.ToInt32(rushHour);

                    for (int i = 0; i < dataGroupedByHourXML.Count; i++)
                    {
                        for (int j = 0; j < objList.Times.Count; j++)
                        {
                            if (objList.Times[j].Hour == dataGroupedByHourXML[i].Key)
                            {
                                objList.Times[j].Count = getItemCountByHour[i];
                                objList.Times[j].Earned = "€" + avgMoneyPerHour[i];
                                if (rushHourInt == i) objList.RushHour = dataGroupedByHourXML[i].Key;
                            }
                        }
                    }

                    string[] removeExt = outputFilePath.Split(".");
                    //string fileName = @"C:\Users\piotr\source\repos\CSharp-From-Zero-To-Hero\Tests\BootCamp.Chapter.Tests\bin\Debug\netcoreapp3.1\test.xml";
                    string fileName = removeExt[0];
                    var jsonString = XmlConvert.SerializeObject(objList);
                    File.WriteAllText(fileName, jsonString);
                }
                ///<summary>
                ///     Export to .csv
                /// </summary>
                else
                {
                    ///<summary>
                    ///     Export data to FullDay.csv
                    /// </summary>
                    //var curDir = @"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Output";
                    var curDir = "";
                    ExportDataToReport.PrintTimeReport(fullDayReportData, Path.Combine(curDir, outputFilePath), "FullDay.csv");
                }
            }
        }
    }
}
