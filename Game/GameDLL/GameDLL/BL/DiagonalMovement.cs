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
        private string direction;
        private int offset;
        private int count;
  
        public DiagonalMovement(int speed, Point boundary, string direction, int offset)
        {
            Speed = speed;
            this.boundary = boundary;
            this.direction = direction;
            this.offset = offset;
            this.count = 0;
        }

        public Point move(Point location)
        {
            if (direction == "right")
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
            else if(direction == "left")
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
                direction = "left";
            }
            else if (location.X+Speed<=0)
            {
                direction="right";
            }
            if (count == 10) count=0;
            count++;
            return location;
        }


    }

}
