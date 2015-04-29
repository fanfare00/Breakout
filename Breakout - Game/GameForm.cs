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
using System.Runtime.InteropServices;

namespace Breakout_Game
{
    public partial class GameForm : Form
    {
        Graphics graphics;

        Paddle paddle;
        Ball ball;
        List<Brick> bricks;
        

        Bitmap bm = new Bitmap(1024, 768);
        Pen pen = new Pen(Color.Black, 1);


        bool pause = true;

        const int PADDLE_SPEED = 15;
        const int TOTAL_LIVES = 3;

        int hitCount = 0;

        public GameForm()
        {
            
            InitializeComponent();
            this.DoubleBuffered = true;

            ball = new Ball();
            paddle = new Paddle(500, 650, 150, 20, PADDLE_SPEED);
            bricks = new List<Brick>();

            setUpBricks(1, 81, 1000, 100, 97, 25, 4);
            

        }

        private void setUpBricks(int posX, int posY, int gridWidth, int gridHeight, int brickWidth, int brickHeight, int padding)
        {
            int startY = posY;
            int startX = posX;
            int colorIndex = 0;

            while (posY < (gridHeight + startY))
            {
                posX = startX;

                while (posX < (gridWidth + startX))
                {
                    bricks.Add(new Brick(posX, posY, brickWidth, brickHeight, colorIndex));
                    posX = posX + brickWidth + padding;
                }

                posY = posY + brickHeight + padding;

                //change color for each row
                colorIndex += 1;

                //repeat colors if rows exceed number of brick colors
                colorIndex = (colorIndex + Brick.ColorBrushes.Count) % Brick.ColorBrushes.Count;
            }
            
        }

        private void timerGameClock_Tick(object sender, EventArgs e)
        {
           // labelDebug.Text = paddle.posX.ToString();

            if (!pause)
            {
                

                handleMouseInput();
                handleKeyboardInput();
                handleCollision();
                ball.update(this.Size);
                Invalidate();

                if (hitCount == bricks.Count)
                {
                    pause = true;
                    panelEndGame.Visible = true;
                    System.Windows.Forms.Cursor.Show();
                    labelUpdateGamesWon.Text = (int.Parse(labelUpdateGamesWon.Text) + 1).ToString();
                }

                if (ball.deathCounter == TOTAL_LIVES)
                {

                    pause = true;
                    panelEndGame.Visible = true;
                    labelLoser.Visible = true;
                    System.Windows.Forms.Cursor.Show();

                }

            }
 



            labelUpdateLives.Text = (TOTAL_LIVES - ball.deathCounter).ToString();
        }

        private void handleMouseInput()
        {
            paddle.PaddleRectangle.X = System.Windows.Forms.Cursor.Position.X;
        }

        private void handleCollision()
        {
            if (ball.BoundingRectangle.IntersectsWith(paddle.PaddleRectangle))
            {
                setBallSpeed();
            }

            foreach (Brick brick in bricks)
            {
                if (ball.BoundingRectangle.IntersectsWith(brick.BrickRectangle))
                {
                    ball.speedY = ball.speedY * -1;
                    brick.BrickRectangle = new Rectangle(0, 0, 0, 0);

                    labelUpdateScore.Text = (int.Parse(labelUpdateScore.Text) + 1).ToString();

                    hitCount += 1;
                }
            }
        }

        private void setBallSpeed()
        {
           // double ballWidth = ball.radius*2;
            double paddleWidth = paddle.PaddleRectangle.Width;
            double speedX = ball.speedX;
            double speedY = ball.speedY;

            // Applying the Pythagorean theorem, calculate the ball's overall
            // speed from its X and Y components.  This will always be a
            // positive value.
            double speedXY = Math.Sqrt(speedX*speedX + speedY*speedY);

            // Calculate the position of the ball relative to the center of
            // the paddle, and express this as a number between -1 and +1.
            // (Note: collisions at the ends of the paddle may exceed this
            // range, but that is fine.)
            double posX = (ball.Center().X - paddle.Center().X) / (paddleWidth / 2);

            // Define an empirical value (tweak as needed) for controlling
            // the amount of influence the ball's position against the paddle
            // has on the X speed.  This number must be between 0 and 1.
            const double influenceX = 0.80;

            // Let the new X speed be proportional to the ball position on
            // the paddle.  Also make it relative to the original speed and
            // limit it by the influence factor defined above.
            speedX = speedXY * posX * influenceX;
            ball.speedX = speedX;

            // Finally, based on the new X speed, calculate the new Y speed
            // such that the new overall speed is the same as the old.  This
            // is another application of the Pythagorean theorem.  The new
            // Y speed will always be nonzero as long as the X speed is less
            // than the original overall speed.
            speedY = Math.Sqrt(speedXY*speedXY - speedX*speedX) *
                     (speedY > 0? -1 : 1);
            ball.speedY = speedY;
        }


        private int distance(Point p1, Point p2)
        {
            double a = Math.Abs(p2.X - p1.X);
            double b = Math.Abs(p2.Y - p1.Y);

            return (int)Math.Sqrt(a * a + b * b);
        }

        private void handleKeyboardInput()
        {

            if ((Keyboard.GetKeyStates(Key.Left) & KeyStates.Down) > 0)
            {
                paddle.moveLeft(this.Size);
            }

            if ((Keyboard.GetKeyStates(Key.Right) & KeyStates.Down) > 0)
            {
                paddle.moveRight(this.Size);
            }

            if ((Keyboard.GetKeyStates(Key.P) & KeyStates.Down) > 0)
            {
                pause = true;
                panelPause.Visible = true;
                System.Windows.Forms.Cursor.Show();
                
            }

        }


        private void GameForm_Load(object sender, EventArgs e)
        {
            graphics = Graphics.FromImage(bm);
            graphics.Clear(this.BackColor);

        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bm, 0, 0);
            

            paddle.draw(e);
            ball.draw(e);

            foreach (Brick brick in bricks)
            {
                brick.draw(e);
            }
        }

        private void pauseMenuButton_Enter(object sender, EventArgs e)
        {
            Button b = sender as Button;

            b.ForeColor = Color.Gold;
        }

        private void pauseMenuButton_Leave(object sender, EventArgs e)
        {
            Button b = sender as Button;

            b.ForeColor = Color.White;
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            pause = false;
            panelPause.Visible = false;
            System.Windows.Forms.Cursor.Hide();

        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();


            MenuForm mainMenu = new MenuForm();
            mainMenu.FormClosed += (s, args) => 
            {
                this.ResetDefault();
                this.Show();
            };
            mainMenu.ShowDialog();
            
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetDefault()
        {
            pause = true;
            panelPause.Visible = false;
            panelEndGame.Visible = false;

            buttonBegin.Visible = true;

            labelUpdateScore.Text = "0";
            ball = new Ball();
            paddle = new Paddle(500, 650, 150, 20, 10);
            bricks = new List<Brick>();

            setUpBricks(1, 81, 1000, 100, 97, 25, 4);

            labelUpdateGamesPlayed.Text = (int.Parse(labelUpdateGamesPlayed.Text) + 1).ToString();

            ball.deathCounter = 0;
            hitCount = 0;
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            ResetDefault();
        }

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Hide();
            buttonBegin.Visible = false;
            pause = false;
        }



    }
}
