using System;
using System.IO;
using System.Collections.Generic;
using BootCamp.Chapter.Robots;
using System.Drawing;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotMKII robotMKII = new RobotMKII();
            Point p = new Point(2,3);

            robotMKII.Move(p);


            Console.ReadKey();
        }
    }
}
