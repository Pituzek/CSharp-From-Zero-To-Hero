using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Times
    {
        public int Hour { get; set; }
        public int Count { get; set; }
        public string Earned { get; set; }

        public Times(int hour, int count, string earned)
        {
            if (hour == 24) hour = 0;
            this.Hour = hour;
            this.Count = count;
            this.Earned = earned;
        }

        public Times()
        {

        }
    }
}
