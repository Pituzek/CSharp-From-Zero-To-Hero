using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BootCamp.Chapter
{
    class ElectricMotor : IMotor
    {
        public string motorType { get; set; }
        public IMovable currentPos;

        public ElectricMotor(string type)
        {
            motorType = type;
        }

        public void Move(Point position)
        {
            throw new NotImplementedException();
        }
    }
}
