using GameDLL.DLLinterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDLL.BL
{
    public class GameObject
    {
        PictureBox pictureBox;
        Move controller;

        public GameObject(Image img,int left,int top, Move controller)
        {
            pictureBox = new PictureBox();
            pictureBox.Image = img;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Left = left;
            pictureBox.Top = top;
            this.controller = controller;
           
        }

        public void update()
        {
            this.pictureBox.Location = controller.move(this.pictureBox.Location);
        }

        public PictureBox getPictureBox()
        {
            return pictureBox;
        }

        public void SetPictureBoxSize(int x,int y)
        {
            this.pictureBox.Size=new System.Drawing.Size(x,y);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public Move getController()
        {
            return controller;
        }
    }
}
