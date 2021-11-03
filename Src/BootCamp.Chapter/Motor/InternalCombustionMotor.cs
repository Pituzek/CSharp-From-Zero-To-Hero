using BootCamp.Chapter.Robots;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace BootCamp.Chapter.Motor
{
    class InternalCombustionMotor : IMotor
    {
        public string motorTypeName { get; set; }

        public InternalCombustionMotor()
        {
            motorTypeName = "Internal combustion engine";
        }
        public override string ToString()
        {
            return string.Format(motorTypeName);
        }
    }
}
