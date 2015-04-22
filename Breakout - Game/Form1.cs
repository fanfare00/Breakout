using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Breakout_Game
{
    public partial class Form1 : Form
    {
        Paddle paddle;
        Ball ball;

        public Form1()
        {
            
            InitializeComponent();
            this.DoubleBuffered = true;
            ball = new Ball(this);
            paddle = new Paddle(this);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timerGameClock_Tick(object sender, EventArgs e)
        {

            this.Refresh();

            handleKeyboardInput();

            ball.update();
            ball.draw();

            paddle.draw();

            labelDebug.Text = ball.posX.ToString() + ", " + ball.posY.ToString();
            
        }

        private void handleKeyboardInput()
        {
            if ((Keyboard.GetKeyStates(Key.Left) & KeyStates.Down) > 0)
            {
                paddle.moveLeft();
            }

            if ((Keyboard.GetKeyStates(Key.Right) & KeyStates.Down) > 0)
            {
                paddle.moveRight();
            }
        }
    }
}
