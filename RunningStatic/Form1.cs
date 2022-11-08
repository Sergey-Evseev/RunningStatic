/*5.Разработать приложение «убегающий статик». Суть приложения: на форме расположен 
статический элемент управления («статик»). Пользователь пытается подвести курсор мыши к «статику», 
и, если курсор находиться близко со статиком, элемент управления «убегает».
Предусмотреть перемещение «статика» только в пределах формы.*/

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
            btnStatic.Click += new EventHandler(btnStatic_Click);
            //btnStatic.MouseClick += btnStatic_Click;
            //btnStatic.MouseClick += new MouseEventHandler(btnStatic_Click);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (((btnStatic.Location.X - e.X) > -20 && (btnStatic.Location.X - e.X) < 20)
                || (btnStatic.Location.Y - e.Y) > -20 && (btnStatic.Location.Y - e.Y) < 20)
            {
                Random rnd = new Random();
                btnStatic.Location = new Point(rnd.Next(this.Size.Width - 20),
                    rnd.Next(this.Size.Height - 20));
            }
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
           // DialogResult result;
            btnStatic.Visible = false;

            DialogResult result = MessageBox.Show($"You caught me! New game?", $"Success", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                btnStatic.Visible = true;
                if (result == DialogResult.No) this.Close();
            }            
        }
    }
}
