using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Minecraft_Launcher_Injector
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void focus(object sender, EventArgs e)
        {
            guna2PictureBox2.Image = Properties.Resources._2;
        }
        private void leave(object sender, EventArgs e)
        {
            guna2PictureBox2.Image = Properties.Resources._1;
        }

        private void click1(object sender, EventArgs e)
        {
            guna2PictureBox2.Image = Properties.Resources._3;
        }

        private void click2(object sender, EventArgs e)
        {
            guna2PictureBox2.Image = Properties.Resources._1;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
