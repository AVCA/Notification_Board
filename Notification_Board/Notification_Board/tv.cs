using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notification_Board
{
    public partial class tv : Form
    {
        public tv()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.showOnScreen(1);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }
        void showOnScreen(int screenNumber)
        {
            Screen[] screens = Screen.AllScreens;
            Console.WriteLine(screens.Length + "Hola");


            if (screenNumber >= 0 && screenNumber < screens.Length)
            {
                bool maximised = false;
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                    maximised = true;
                }
                Location = screens[screenNumber].WorkingArea.Location;
                if (maximised)
                {
                    WindowState = FormWindowState.Maximized;
                }
            }
        }
        private void tv_Load(object sender, EventArgs e)
        {

        }
    }
}
