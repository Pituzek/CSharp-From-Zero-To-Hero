using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BootCamp.Chapter.Robots
{
    class RobotMKII 
    {
        public string motorType { get; set; }
        private Point _position;
        private IMotor _motorMkII;

        public RobotMKII()
        {
            _position = (new Point(0, 0));
            _motorMkII = new ElectricMotor();
        }

        public void Move(Point position)
        {
            _position = position;
        }
    }
}
