using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    interface IMotor : IMovable
    {
        string motorType { get; set; }

    }
}
