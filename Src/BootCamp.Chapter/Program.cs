using System;
using System.IO;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            

            string[] arrayS = new string[5];

            foreach (var test in arrayS)
            {
                Console.WriteLine(test);
            }

            updateArray(arrayS);

            foreach(var test in arrayS)
            {
                logger.Log($"{test}");
            }

            Console.ReadKey();
        }

        public static void updateArray(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = "test " + i;
            }
        }
    }
}
