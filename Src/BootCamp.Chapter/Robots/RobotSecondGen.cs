using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BootCamp.Chapter.Robots
{
    class RobotSecondGen : IMkII
    {
        public string motorTypeName { get; set; }
        public string shakerModelName { get; set; }

        private Point _position;

        private IMotor _motorMkII;

        private IShaker _shakerMkII;

        private bool _isAbleToMakeCoctail;

        public bool IsAbleToMakeCoctail
        {
            get { return _isAbleToMakeCoctail; }
        }

        private bool _isMobile;
        public bool IsMobile
        {
            get { return _isMobile; }
            set
            {
                if (_motorMkII != null) // prevents user for move enable without engine present (can implement engine failure later)
                {
                    _isMobile = value;
                }
            }
        }

        private int _id;
        public int Id
        {
            get { return _id; }
        }

        public RobotSecondGen(int id, Point initialPos, IMotor motorType = null)
        {
            _id = id;
            _position = initialPos;
            _motorMkII = motorType;
            _shakerMkII = shakerType;
            _isAbleToMakeCoctail = false;

            if (_motorMkII != null)
            {
                _isMobile = true;
            }
            else
            {
                _isMobile = false;
            }
        }

        public void Move(Point position)
        {
            if (_isMobile)
            {
                _position = position;
            }
            else
            {
                throw new Exception("Robot cannot move, please mount or fix his engine");
            }
        }

        public Point GetRobotPosition()
        {
            return _position;
        }
    }
}
