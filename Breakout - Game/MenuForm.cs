using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout_Game
{
    public partial class MenuForm : Form
    {
        private bool canStart;
        private string loginName;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void menuButton_Enter(object sender, EventArgs e)
        {
            Button b = sender as Button;

            b.ForeColor = Color.Gold;
            b.BackColor = Color.Black;
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (canStart == false)
            {
                Application.Exit();
            }
        }

        private void menuButton_Leave(object sender, EventArgs e)
        {
            Button b = sender as Button;

            b.ForeColor = Color.White;
            b.BackColor = Color.Black;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            panelMainMenu.Visible = false;
            panelLogin.Visible = true;

            labelLogin.Visible = true;
        }

        private void buttonLoginContinue_Click(object sender, EventArgs e)
        {
            if (validLogin())
            {
                panelLogin.Visible = false;
                panelAlias.Visible = true;

                labelLogin.Visible = false;
                labelAlias.Visible = true;

                MessageBox.Show("You successfully logged in as " + loginName + ".", "LOGIN SUCCESS");
            }
            else
            {
                MessageBox.Show("Invalid account number. Please try again", "LOGIN FAILED");
            }
        }

        private bool validLogin()
        {
            bool valid = false;

            int accNumber;

            if (int.TryParse(textBoxAccountNumber.Text, out accNumber))
            {
                
            }
            else
            {
                return false;
            }

            switch (accNumber)
            {
                case 1111:
                    valid = true;
                    loginName = "Albert Einstein";
                    break;

                case 2222:
                    valid = true;
                    loginName = "Madame Curie";
                    break;

                case 3333:
                    valid = true;
                    loginName = "James McCarthy";
                    break;

                case 4444:
                    valid = true;
                    loginName = "Richard Feynman";
                    break;

                case 5555:
                    loginName = "Sean Carroll";
                    valid = true;
                    break;

                default:
                    valid = false;
                    break;
            }

            return valid;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelAlias.Visible = false;
            panelMainMenu.Visible = true;

            labelLogin.Visible = false;
            labelAlias.Visible = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for playing " + textBoxAlias.Text + ".", "WELCOME");
            canStart = true;
            Close();
        }


    }
}
