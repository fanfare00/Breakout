using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout_Game
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            SplashForm splashForm = new SplashForm();
            MenuForm menuForm = new MenuForm();
            GameForm gameForm = new GameForm();
            
            splashForm.ShowDialog();
            menuForm.ShowDialog();
            gameForm.ShowDialog();
            
        }
    }
}
