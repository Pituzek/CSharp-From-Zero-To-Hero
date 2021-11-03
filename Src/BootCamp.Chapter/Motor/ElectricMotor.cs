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
        //public Point _position;

        public ElectricMotor()
        {
            motorTypeName = "Electric engine";
        }

        //public void Move(Point position)
        //{
        //    _position = position;
        //}

        //public Point MoveWithEngine(Point position)
        //{
        //    throw new NotImplementedException();
        //}

        //public void MoveWithEngine(Point position, IMkII robot)
        //{
        //    throw new NotImplementedException();
        //}

        //public void MoveRobotByEngine(Point position, IMkII robot, IMotor engineType)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
