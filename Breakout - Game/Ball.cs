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
    public class Ball
    {
        public int radius;
        public int posX; 
        public int posY; 
        public int speedX;
        public int speedY;

        Form _drawForm;
        Graphics graphics;

        public Ball(Form drawForm)
        {
            _drawForm = drawForm;

            this.radius = 20;
            this.posX = 500;
            this.posY = 500;
            this.speedX = 10;
            this.speedY = 10;

            graphics = drawForm.CreateGraphics();
        }

        public void draw()
        {
            graphics.FillEllipse(Brushes.Red, posX, posY, radius, radius);
        }

        public void update()
        {
            checkOutOfBounds();

            posX += speedX;
            posY += speedY;
        }

        public void checkOutOfBounds()
        {
            if ((posX + speedX < 0) || (posX + speedX + radius > _drawForm.Size.Width))
            {
                speedX = speedX * -1;
            }
            else if ((posY + speedY < 0) || (posY + speedY + radius > _drawForm.Size.Height))
            {
                speedY = speedY * -1;
            }
        }

    }
}
