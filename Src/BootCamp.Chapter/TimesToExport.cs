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

        public TimesToExport(DateTime startTime, DateTime endTime)
        {
                createHourList(Times, startTime, endTime);
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

        public static void createHourList(List<Times> list, DateTime startTime, DateTime endTime)
        {
            var endHour = 0;
            if (endTime.Hour == 0)
            {
                endHour = 24;
            }
            else
            {
                endHour = endTime.Hour;
            }

            for (int i = startTime.Hour; i <= endHour; i++)
            {
                Times test = new Times(i, 0, "€0");
                list.Add(test);
            }
        }
    }
}
