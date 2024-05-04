using GameDLL.DLLinterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDLL.BL
{
    public class DiagonalMovement:Move
    {
        private int Speed;
        private Point boundary;
        private Directions direction;
        private int offset;
        private int count;
  
        public DiagonalMovement(int speed, Point boundary, Directions direction, int offset)
        {
            Speed = speed;
            this.boundary = boundary;
            this.direction = direction;
            this.offset = offset;
            this.count = 0;
        }

        public Point move(Point location)
        {
            if (direction == Directions.right)
            {
                if (count < 5)
                {
                    location.X += Speed;
                    location.Y -= Speed;
                }
                else if(count >= 5 && count<10)
                {
                    location.X += Speed;
                    location.Y += Speed;
                }
            }
            else if(direction == Directions.left)
            {
                if (count < 5)
                {
                    location.X -= Speed;
                    location.Y += Speed;
                }
                else if (count >= 5 && count < 10)
                {
                    location.X -= Speed;
                    location.Y -= Speed;
                }
            }
            if (location.X+offset>=boundary.X)
            {
                direction = Directions.left;
            }
            else if (location.X+Speed<=0)
            {
                direction=Directions.right;
            }
            if (count == 10) count=0;
            count++;
            return location;
        }


    }

}
