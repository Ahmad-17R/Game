﻿using GameDLL.DLLinterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDLL.BL
{
    public class HorizontalMovement:Move
    {
        private int Speed;
        private Point boundary;
        private Directions direction;
        private int offset;

        public HorizontalMovement(int speed, Point boundary, Directions direction,int offset)
        {
            Speed = speed;
            this.boundary = boundary;
            this.direction = direction;
            this.offset = offset;
        }

        public Point move(Point location)
        {
            if ((location.X+offset)>=boundary.X)
            {
                direction = Directions.left;
            }
            else if (location.X+Speed <=0)
            {
                direction=Directions.right;

            }
             if (direction==Directions.left)
            {
                location.X-=Speed;
            }
            else
            {
                location.X+=Speed;
            }
             return location;
        }


    }
}
