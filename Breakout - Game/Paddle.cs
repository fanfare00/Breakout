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
        int width;
        int height;
        int posX;
        int posY;
        int speedX;

        Form _drawForm;
        Graphics graphics;

        public Paddle(Form drawForm)
        {
            _drawForm = drawForm;
            graphics = drawForm.CreateGraphics();

            width = 150;
            height = 20;
            posX = 500;
            posY = 700;
            speedX = 10;
        }

        public void draw()
        {
            graphics.FillRectangle(Brushes.Blue, posX, posY, width, height);
        }

        public void moveLeft()
        {
            posX -= speedX;
        }

        public void moveRight()
        {
            posX += speedX;
        }

        public void checkOutOfBounds()
        {
            if (posX + width > _drawForm.Width)
            {
                //speedX = 0;
            }
        }


    }
}
