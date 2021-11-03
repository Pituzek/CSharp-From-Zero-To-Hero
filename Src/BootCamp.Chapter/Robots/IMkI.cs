using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Robots
{
    interface IMkI : IShaker
    {
        int Id { get; }
        bool IsMobile { get; set; }
        bool IsAbleToMakeCoctail { get; }
    }
}
