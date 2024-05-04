using GameDLL.DLLinterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDLL.BL
{
    public class VerticalMovement:Move
    {
        private int Speed;
        private Point boundary;
        private Directions direction;
        private int offset ;

        public VerticalMovement(int speed, Point boundary, Directions direction,int offset)
        {
            Speed = speed;
            this.boundary = boundary;
            this.direction = direction;
            this.offset = offset;
        }

        public Point move(Point location)
        {
            if ((location.Y + offset) >= boundary.Y)
            {
                direction = Directions.up;
            }
            else if (location.Y - Speed <= 0)
            {
                direction = Directions.down;

            }
            if (direction == Directions.up)
            {
                location.Y -= Speed;
            }
            else
            {
                location.Y += Speed;
            }
            return location;
        }
    }
}
