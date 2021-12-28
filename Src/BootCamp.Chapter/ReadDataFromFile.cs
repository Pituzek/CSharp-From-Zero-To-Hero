using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    public static class ReadDataFromFile
    {
        public static List<string> GetData(bool debug = false)
        {
            string filePath = @"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Addresses.txt";
            List<string> data = new List<string>();
            StreamReader sr = new StreamReader(filePath);

            using (sr)
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (debug) Console.WriteLine(line);
                    data.Add(line);
                }
            }
            return data;
        }
    }
}
