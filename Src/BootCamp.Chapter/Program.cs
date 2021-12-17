﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> command = new List<string>();

            DateTime startTime = new DateTime();
            DateTime endTime = new DateTime();

            string filePath = string.Empty;
            string outputFilePath = string.Empty;
            string fileExtension = string.Empty;

            bool isJson = false;
            bool isXml = false;

            if (args == null || args.Length == 0)
            {
                ///<summary>
                ///     For debug without automated tests
                /// </summary>
                filePath = @"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Transactions.csv";
                //command.Add("time");

                //command.Add("city");
                //command.Add("money");
                //command.Add("min");

                command.Add("daily");
                command.Add("Kwiki");
                command.Add("Mart");

                startTime = new DateTime(2021, 1, 1, 0, 11, 0, 0);
                endTime = new DateTime(2021, 1, 1, 0, 17, 0, 0); ;
                outputFilePath = @"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Output";
            }
            else
            {
                filePath = args[0];

                ///<summary>
                ///     check count of passed arguments, to contain "path/to/input" "command" "path/to/output"
                /// </summary>
                if (args.Length != 3)
                    throw new InvalidCommandException();

                string[] commandString = args[1].Split(new char[] { '-', ' ' });

                ///<summary>
                ///     check for invalid command name
                /// </summary>
                if (commandString[0] != "time" && commandString[0] != "city" && commandString[0] != "daily" && commandString[0] != "full")
                    throw new InvalidCommandException();

                foreach (var data in commandString)
                {
                    if (data != "") command.Add(data);
                }
                outputFilePath = args[2];

                if (args[0].Contains(".json"))
                {
                    fileExtension = ".json";
                    isJson = true;
                    isXml = false;
                }
                else if (args[0].Contains(".xml"))
                {
                    fileExtension = ".xml";
                    isXml = true;
                    isJson = false;
                }
                else
                {
                    fileExtension = ".csv";
                    isJson = false;
                    isXml = false;
                }
            }

            ImportTransactionsData dataInput = new ImportTransactionsData();

            if (isJson)
            {
                ///<summary>
                ///     Data import from .json
                /// </summary>
                /// 
                string fileName = @"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Tests\BootCamp.Chapter.Tests\Input\Transactions.json";
                string jsonString = File.ReadAllText(fileName);
                //var transactionImportOK = JsonConvert.DeserializeObject<List<TransactionsJSON>>(jsonString);
                var transactionsReadFromJson = JsonConvert.DeserializeObject<List<Transactions>>(jsonString);

                dataInput.AddTransactionList(transactionsReadFromJson);
            }

            if (isXml)
            {
                ///<summary>
                ///     Data import from .xml
                /// </summary>
            }

            if (!isJson && !isXml)
            {
                ///<summary>
                ///     Data import from .csv
                /// </summary>
                dataInput.ImportTransactionsDataT(filePath);
            }

            ///<summary>
            ///     Check imported data (for manual debug)
            ///</summary>
            bool debug = false;
            if (debug)
            {
                DebugInput(dataInput);
            }

            ///<summary>
            ///     check if any data was imported
            /// </summary>
            var isNotEmpty = dataInput.Data.Any();

            switch (command[0].ToLowerInvariant())
            {
                case "city":
                    ///<summary>
                    ///      Find city name with min/max money/items
                    /// </summary>
                    FilterByItemMoney.FindCityNameMinMax(dataInput, command, outputFilePath, fileExtension);
                    break;

                case "time":
                    if (command.Count == 1)
                    {
                        ///<summary>
                        ///     FullDay.csv by "time" command, without time range
                        /// </summary>
                        FilterByTime.FilterByTimeFullDay(dataInput, command, outputFilePath);
                    }
                    else
                    {
                        ///<summary>
                        ///     FullDay.csv by "time" command, including time range
                        /// </summary>
                        FilterByTime.FilterByTimeHourRange(dataInput, command, outputFilePath);
                    }
                    break;

                case "daily":
                    ///<summary>
                    ///     Daily money earned for specific shop.
                    /// </summary>
                    FilterByDay.PrintDayAndMoneyEarned(dataInput, command, outputFilePath);
                    break;

                case "full":
                    //sortowanie po nazwie sklepu, nazwa pliku NazwaSklepu.csv ; w pliku wszystkie informacje oprocz nazyw sklepu bo to okresla nazwa pliku
                    break;
            }

            //Console.ReadKey();
        }

        private static void DebugInput(ImportTransactionsData dataInput)
        {
            List<Transactions> data = dataInput.Data;

            for (int i = 0; i < dataInput.Data.Count; i++)
            {
                Console.WriteLine(dataInput.Data[i]);
            }
        }
    }
}
