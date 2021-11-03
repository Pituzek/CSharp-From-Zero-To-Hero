using System;
using System.Collections.Generic;
using System.Text;


namespace BootCamp.Chapter.Robots
{
    interface IMkII : IMotor, IMovable
    {
        int Id { get; }
        bool IsMobile { get; set; }
    }
}
