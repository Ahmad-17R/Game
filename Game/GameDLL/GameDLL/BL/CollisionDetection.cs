using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDLL.BL
{
    public class CollisionDetection
    {
        GameObject type1;
        GameObject type2;

        public  CollisionDetection(GameObject type1, GameObject type2)
        { 
            this.type1 = type1;
            this.type2 = type2;
        }

        public static bool IsCollided(GameObject type1, GameObject type2)
        
        {
           
                Rectangle rectangle1=type1.getPictureBox().Bounds;
            Rectangle rectangle2 = type2.getPictureBox().Bounds;

            return rectangle1.IntersectsWith(rectangle2);

        }
     
    }
}
