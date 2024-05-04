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
        private static GameObject ObjectInstance;
        private ObjectType objectType;
        public int health;
        private GameObject(Image img,int left,int top, Move controller,ObjectType type,int health)
        {
            pictureBox = new PictureBox();
            pictureBox.Image = img;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Left = left;
            pictureBox.Top = top;
            this.controller = controller;
            this.objectType = type;
            this.health = health;
            SetObjectType(type);
        }

        public static GameObject CreateGameObject(Image img, int left, int top, Move controller, ObjectType type,int health)
        {
            if(type==ObjectType.player && Factorypattern.Players < 1)
            {
                ObjectInstance = new GameObject(img,  left,  top,  controller,  type,health);
            }
            else if (type == ObjectType.enemy && Factorypattern.Enemies < 3)
            {
                ObjectInstance = new GameObject(img, left, top, controller, type, health);
            }
            return ObjectInstance;
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

        public void SetObjectType(ObjectType type)
        {
            if (type == ObjectType.player)
            {

            }
        }

        public ObjectType getObjectType()
        {
            return objectType;
        }

        public void Sethealth(int health)
        {
            this.health= health;
        }

        public int getHealth()
        {
            return this.health;
        }
    }
}
