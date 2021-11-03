using System;
using System.IO;
using System.Collections.Generic;
using BootCamp.Chapter.Robots;
using BootCamp.Chapter.Motor;
using System.Drawing;


namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            InternalCombustionMotor icMotor = new InternalCombustionMotor();
            RobotSecondGen robotMKII = new RobotSecondGen(1, new Point());
            Point p = new Point(2,3);

            Point posBeforeMove = robotMKII.GetRobotPosition();
            Console.WriteLine(posBeforeMove.ToString());

            robotMKII.Move(p);

            Point newPosition = robotMKII.GetRobotPosition();
            Console.WriteLine(newPosition.ToString());

            Console.ReadKey();
        }
    }
}
