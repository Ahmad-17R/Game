using GameDLL.BL;
using Mygame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mygame
{
    public partial class Form1 : Form
    {
        private Timer timer1;
        Game game;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //InitializePictureBox(x,y);
            InitializeTimer();
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             game = new Game(this);  
            Point boundary=new Point(this.Width,this.Height);
            GameObject Verticalenemy = new GameObject(Resources.enemy1, 1155, 10, new VerticalMovement(8, boundary,"down",190));
            GameObject Horizontalenemy = new GameObject(Resources.enemy2, 110, 10, new HorizontalMovement(8, boundary, "right",250));
            GameObject ZigZagEnenmy = new GameObject(Resources.enemy1, 300, 375, new DiagonalMovement(8, boundary, "right", 250));
            GameObject player = new GameObject(Resources.mytank2,200,50,new KeyboardMovement(15,boundary,180));
            player.SetPictureBoxSize(120,100);
            ZigZagEnenmy.SetPictureBoxSize(120,100);
            Horizontalenemy.SetPictureBoxSize(120, 100);
            Verticalenemy.SetPictureBoxSize(120,100);
            game.AddGameObjects(Verticalenemy);
            game.AddGameObjects(Horizontalenemy);
            game.AddGameObjects(ZigZagEnenmy);
            game.AddGameObjects(player);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            game.update();
        }

        private void InitializeTimer()
        {
            timer1 = new Timer();
            timer1.Interval = 50; // Adjust rotation speed as needed
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        enum directions
        {
            up,down,right,left
        }

    }
}

        //private void InitializePictureBox(int x,int y)
        //{
        //    pictureBox1 = new PictureBox();
        //    pictureBox1.Image = Properties.Resources.mytank2; // Replace with your image
        //    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        //    pictureBox1.BackColor = Color.Transparent;
        //    pictureBox1.Size = new System.Drawing.Size(120, 100);
        //    pictureBox1.Location = new System.Drawing.Point(x, y);
        //    this.Controls.Add(pictureBox1);
        //}
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == Keys.Up )
        //    {
        //        if (direction == "Right" ) { 
                
        //        pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            direction = "Up";
                  
        //        }
        //        if (direction == "Down")
        //        {

        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            direction = "Up";
        //        }
        //        if (direction == "Left")
        //        {

        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }

        //            direction = "Up";
        //        }
        //        if (direction=="Up")
        //        {
        //            y-= 15;
        //            pictureBox1.Location = new System.Drawing.Point(x, y);
        //            if (y < -95)
        //            {
        //                y = 650;
        //                pictureBox1.Location = new System.Drawing.Point(x, y);
        //            }
        //        }
        //        // Rotate the picture box manually when 'R' key is pressed
        //        pictureBox1.Invalidate(); // Force redrawing
        //    }
        //    //////Right--Key
        //    if (keyData == Keys.Right)
        //    {
        //        if (direction == "Up")
        //        {

        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }

        //            direction = "Right";
        //        }
        //        if (direction == "Down")
        //        {

        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            direction = "Right";
        //        }
        //        if (direction == "Left")
        //        {

        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }

        //            direction = "Right";
        //        }
        //        if (direction == "Right")
        //        {
        //            x += 15;

        //            pictureBox1.Location = new System.Drawing.Point(x, y);
        //            if (x > 1265)
        //            {
        //                x = -100;
        //                pictureBox1.Location = new System.Drawing.Point(x, y);
        //            }
        //        }

        //        // Rotate the picture box manually when 'R' key is pressed
        //        pictureBox1.Invalidate(); // Force redrawing
        //    }

        //    if (keyData == Keys.Down )
        //    {
        //        if (direction == "Up")
        //        {

        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            direction = "Down";
        //        }
        //        if (direction == "Right")
        //        {

        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
          
        //            direction = "Down";
        //        }
        //        if (direction == "Left")
        //        {

        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }

        //            direction = "Down";
        //        }
        //        if (direction == "Down")
        //        {
        //            y += 15;

        //            pictureBox1.Location = new System.Drawing.Point(x, y);
        //            if (y >635)
        //            {
        //                y = -95;
        //                pictureBox1.Location = new System.Drawing.Point(x, y);
        //            }
        //        }
        //        // Rotate the picture box manually when 'R' key is pressed
        //        pictureBox1.Invalidate(); // Force redrawing
        //    }

        //    if (keyData == Keys.Left )
        //    {
        //        if (direction == "Up")
        //        {

        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            direction = "Left";
        //        }
        //        if (direction == "Right")
        //        {

        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }

        //            direction = "Left";
        //        }
        //        if (direction == "Down")
        //        {

        //            pictureBox1.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        //            rotationAngle += 90;
        //            if (rotationAngle >= 360) { rotationAngle = 0; }
    

        //            direction = "Left";
        //        }
        //        if (direction == "Left")
        //        {
        //            x -= 15;
        //            pictureBox1.Location = new System.Drawing.Point(x, y);
        //            if (x < -100)
        //            {
        //                x = 1265;
        //                pictureBox1.Location = new System.Drawing.Point(x, y);
        //            }
        //        }
        //        // Rotate the picture box manually when 'R' key is pressed
        //        pictureBox1.Invalidate(); // Force redrawing
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}