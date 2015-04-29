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
        public double posX; 
        public double posY; 
        public double speedX;
        public double speedY;

        public int deathCounter;

        public Rectangle BoundingRectangle;

        
        //Graphics graphics;

        public Ball()
        {
            deathCounter = 0;

            this.radius = 20;
            this.posX = 200;
            this.posY = 200;
            this.speedX = 7;
            this.speedY = 7;

            BoundingRectangle = new Rectangle(Center().X, Center().Y-10, 1, 30);
        }

        public void draw(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, (int)posX, (int)posY, radius, radius);
            
        }

        public void update(Size gameSize)
        {
            checkOutOfBounds(gameSize);

            posX += speedX;
            posY += speedY;

            BoundingRectangle.X = Center().X;
            BoundingRectangle.Y = Center().Y-15;


            
        }

        public Point Center()
        {
            return new Point((int)(posX + radius / 2),
                             (int)(posY + radius / 2));
        }

        public void checkOutOfBounds(Size gameSize)
        {
            if ((posX + speedX < 0) || (posX + speedX + radius > gameSize.Width))
            {
                speedX = speedX * -1;
            }
            else if ((posY + speedY < 70))
            {
                speedY = speedY * -1;
            }
            else if (posY + speedY + radius > gameSize.Height)
            {
                deathCounter += 1;

                this.posX = 200;
                this.posY = 200;
                this.speedX = 7;
                this.speedY = 7;
            }
        }

    }
}
