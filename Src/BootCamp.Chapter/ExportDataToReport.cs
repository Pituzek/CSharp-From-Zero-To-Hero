using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json;

namespace BootCamp.Chapter
{
    public static class ExportDataToReport
    {
        public static void PrintTimeReport(List<List<string>> outputFile, string outputPath, string fileName)
        {
            try
            {
                string filePath = outputPath;
                string dirPath = Path.GetDirectoryName(outputPath);
                if (!Directory.Exists(outputPath))
                    Directory.CreateDirectory(outputPath);

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                var enc1252 = Encoding.GetEncoding(1252); 

                using (StreamWriter sw = new StreamWriter(Path.Combine(outputPath, fileName)))
                {
                    int count = 0;
                    foreach (var data in outputFile)
                    {
                        List<string> lines = data;
                        CultureInfo invC = CultureInfo.InvariantCulture;
                        if (count < 1) sw.WriteLine("Hour, Count, Earned");
                        if (count >= 0 && count < 10) sw.WriteLine("0" + lines[0] + ", " + lines[1] + ", \"" + lines[2] + '€' + "\"", new UTF8Encoding(true)); //€ "\u20AC"
                        if (count >= 10 && count < 24) sw.WriteLine(lines[0] + ", " + lines[1] + ", \"" + lines[2] + " \u20AC" + "\"", Encoding.Default); //€ "\u20AC"
                        if (count == 24) sw.WriteLine(lines[0]);
                        count++;
                    }
                }

                Console.WriteLine("File has been written to hdd");
            }
            catch(Exception ex)
            {
                Console.WriteLine("**** ERRROR ****");
                Console.WriteLine(ex);
            }
        }

        public static void PrintMinMaxReport(string cityName, string outputPath, string fileExtension)
        {
            try
            {
                //string filePath = outputPath;
                //string dirPath = Path.GetDirectoryName(outputPath);
                //if (!Directory.Exists(outputPath))
                //    Directory.CreateDirectory(outputPath);

                bool isJson = fileExtension.Equals(".json");
                bool isXml = fileExtension.Equals(".xml");

                if (isJson)
                {
                    ///<summary>
                    ///     Export to .json
                    /// </summary>
                    string fileName = outputPath;
                    string jsonString = JsonConvert.SerializeObject(cityName);
                    File.WriteAllText(fileName, jsonString);
                    
                }
                else if (isXml)
                {
                    ///<summary>
                    ///     Export to .xml
                    /// </summary>
                    string fileName = outputPath;
                    var xml = XmlConvert.SerializeObject(cityName);
                    File.WriteAllText(fileName, xml);
                }

                if (!isJson && !isXml)
                {
                    ///<summary>
                    ///     Export data to .csv
                    /// </summary>
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    var enc1252 = Encoding.GetEncoding(1252);

                    using (StreamWriter sw = new StreamWriter(outputPath)) //Path.Combine(outputPath, fileName)
                    {
                        CultureInfo invC = CultureInfo.InvariantCulture;
                        sw.WriteLine(cityName);
                    }
                }
              
            }
            catch(Exception ex)
            {
                Console.WriteLine("**** ERRROR ****");
                Console.WriteLine(ex);
            }
        }

        public static void PrintDailyReport(List<List<String>> data, string outputPath, string shopName, string fileName)
        {
            try
            {
                bool isJson = outputPath.Contains(".json");
                bool isXml = outputPath.Contains(".xml");

                ///<summary>
                ///     Export to .json
                /// </summary>
                if (isJson)
                {
                    DailyJSON dailyData = new DailyJSON();

                    foreach (var day in data)
                    {
                        if (day.Count > 0)
                        {
                            dailyData = new DailyJSON(day[0], day[1]);
                        }
                    }

                    string[] removeExt = outputPath.Split(".");
                    fileName = removeExt[0];
                    var jsonString = JsonConvert.SerializeObject(dailyData);
                    jsonString = JsonConvert.SerializeObject(dailyData, Formatting.Indented);
                    File.WriteAllText(fileName, jsonString);
                }

                ///<summary>
                ///     Export to .xml
                /// </summary>
                if (isXml)
                {
                    throw new NotImplementedException("Export to .xml not yet implemented");
                }

                ///<summary>
                ///     Export to .csv
                /// </summary>
                if (!isJson && !isXml)
                {
                    int count = 0;
                    string filePath = outputPath;
                    string dirPath = Path.GetDirectoryName(outputPath);
                    if (!Directory.Exists(outputPath))
                        Directory.CreateDirectory(outputPath);

                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    var enc1252 = Encoding.GetEncoding(1252);

                    using (StreamWriter sw = new StreamWriter(Path.Combine(outputPath, fileName)))
                    {
                        CultureInfo invC = CultureInfo.InvariantCulture;

                        foreach (var day in data)
                        {
                            if (count < 1) sw.Write("Day, Earned" + Environment.NewLine);
                            sw.Write(day[0] + ", \"" + day[1] + " €\"" + Environment.NewLine);
                            if (count < 2) count++;
                        }
                    }
                }
              
            }
            catch (Exception ex)
            {
                Console.WriteLine("**** ERRROR ****");
                Console.WriteLine(ex);
            }
        }

    }
}
