using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Breakout_Game
{
    class Paddle
    {
        public int Speed;

        public Rectangle PaddleRectangle;
        

        public Paddle(int posX, int posY, int width, int height, int speed)
        {
            Speed = speed;

            PaddleRectangle = new Rectangle(posX, posY, width, height);
        }

        public void draw(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, PaddleRectangle);
        }

        public void moveLeft(Size gameSize)
        {
            if ((PaddleRectangle.X - Speed) > 0)
            {
                PaddleRectangle.X -= Speed;
            }
                
        }

        public void moveRight(Size gameSize)
        {
            if ((PaddleRectangle.X + PaddleRectangle.Width + Speed) < gameSize.Width)
            {
                PaddleRectangle.X += Speed;
            }
        }

        public Point Center()
        {
            return new Point(PaddleRectangle.Left + PaddleRectangle.Width / 2,
                             PaddleRectangle.Top + PaddleRectangle.Height / 2);
        }


    }
}
