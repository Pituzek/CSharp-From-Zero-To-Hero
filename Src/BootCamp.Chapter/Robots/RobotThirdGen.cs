using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BootCamp.Chapter.Robots
{
    class RobotThirdGen : IMkIII
    {
        public int Id => throw new NotImplementedException();

        public bool IsMobile { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsAbleToMakeCoctail => throw new NotImplementedException();

        public string shakerModelName => throw new NotImplementedException();

        public string motorTypeName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Move(Point position)
        {
            throw new NotImplementedException();
        }
    }
}
