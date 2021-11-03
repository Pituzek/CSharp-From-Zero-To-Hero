using BootCamp.Chapter.Robots;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace BootCamp.Chapter.Motor
{
    class InternalCombustionMotor : IMotor
    {
        private Point _position;
        public string motorTypeName { get; set; }

        public InternalCombustionMotor()
        {
            motorTypeName = "Internal combustion engine";
        }

        public void Move(Point position)
        {
            _position = position;
        }

        public void MoveRobotByEngine(Point position, IMkII robot, IMotor engineType)
        {
            robot.Move(position);
        }
    }
}
