using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BootCamp.Chapter
{
    class ElectricMotor : IMotor
    {
        public string motorType { get; set; }
        public IMotor currentPos;

        public ElectricMotor()
        {
            motorType = "electric";
        }

        public void Move(Point position)
        {
            currentPos = position;
        }
    }
}
