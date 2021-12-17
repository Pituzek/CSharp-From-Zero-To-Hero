using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class TimesToExport
    {
        public List<Times> Times { get; set; } = new List<Times>();
        public int RushHour { get; set; }
        public TimesToExport()
        {
            createDefaultList(Times);
            RushHour = -1;
        }
        public static void createDefaultList(List<Times> list)
        {
            for (int i = 0; i < 24; i++)
            {
                Times test = new Times(i, 0, "€0");
                list.Add(test);
            }

        }
    }
}
