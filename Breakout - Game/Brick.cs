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
    class Brick
    {
        public Rectangle BrickRectangle { get; set; }

        public static List<Brush> ColorBrushes = new List<Brush>(new Brush[] 
                {
                    Brushes.Red, 
                    Brushes.Orange, 
                    Brushes.Yellow, 
                    Brushes.LawnGreen, 
                    Brushes.LightBlue, 
                    Brushes.Blue, 
                    Brushes.Purple, 
                    Brushes.Violet
                });

        int ColorIndex;

        public Brick(int posX, int posY, int width, int height, int colorIndex)
        {
            BrickRectangle = new Rectangle(posX, posY, width, height);
            ColorIndex = colorIndex;
        }

        public void draw(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(ColorBrushes[ColorIndex], BrickRectangle);
        }

        public Point Center()
        {
            return new Point(BrickRectangle.Left + BrickRectangle.Width / 2,
                             BrickRectangle.Top + BrickRectangle.Height / 2);
        }
         
    }
}
