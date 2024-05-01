using EZInput;
using GameDLL.DLLinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDLL.BL
{
    public class KeyboardMovement:Move
    {
        private int Speed;
        private  System.Drawing.Point boundary;
        private int offset;

        public KeyboardMovement(int Speed, System.Drawing.Point boundary,int offset)
        {
            this.Speed = Speed;
            this.boundary = boundary;
            this.offset = offset;
        }
        public System.Drawing.Point move(System.Drawing.Point location)
        {
            if (EZInput.Keyboard.IsKeyPressed(Key.UpArrow))
            {
                if (location.Y + Speed > 10)
                {
                    location.Y-=Speed;
                }
            }
            //////Right--Key
            if (EZInput.Keyboard.IsKeyPressed(Key.DownArrow))
            {
                if (location.Y + offset < boundary.Y)
                {
                    location.Y += Speed;
                }
            }

            if (EZInput.Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                if (location.X + Speed > 10)
                {
                    location.X -= Speed;
                }
            }

            if (EZInput.Keyboard.IsKeyPressed(Key.RightArrow))
            {
                if (location.X + offset < boundary.X)
                {
                    location.X += Speed;
                }
            }

            return location;
        }
    }
}
