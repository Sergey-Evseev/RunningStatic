using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningStatic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += Form1_MouseMove; 
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (((btnStatic.Location.X - e.X) > -50 && (btnStatic.Location.X - e.X) < 50)
                || (btnStatic.Location.Y - e.Y) > -50 && (btnStatic.Location.Y - e.Y) < 50)
            {
                Random rnd = new Random();
                btnStatic.Location = new Point(rnd.Next(this.Size.Width - 100), 
                    rnd.Next(this.Size.Height - 100));
            }
        }
    }
}
