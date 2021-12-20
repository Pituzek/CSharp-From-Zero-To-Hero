using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class DailyJSON
    {
        public string Day { get; set; }
        public string Earned { get; set; }

        public DailyJSON(string day, string earned)
        {
            this.Day = day;
            this.Earned = earned;
        }

        public DailyJSON()
        {

        }
    }
}
