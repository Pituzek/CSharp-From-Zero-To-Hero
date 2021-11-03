using BootCamp.Chapter.Robots;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BootCamp.Chapter
{
    class ElectricMotor : IMotor
    {
        public string motorTypeName { get; set; }

        public ElectricMotor()
        {
            motorTypeName = "Electric engine";
        }
        public override string ToString()
        {
            return string.Format(motorTypeName);
        }
    }
}
