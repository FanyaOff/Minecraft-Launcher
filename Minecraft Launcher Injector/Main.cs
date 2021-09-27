using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Launcher_Injector
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            label5.Text = Environment.UserName;
            label7.Text = Environment.UserName;
            guna2Panel3.Visible = true;
            guna2Panel1.Visible = true;
            guna2Button2.Text = "Minecraft:\nJava Edition";
            guna2Button3.Text = "Minecraft:\nDungeons";

        }
        private void ButtonMouseEnter(object sender, EventArgs e)
        {
            guna2PictureBox2.Image = Properties.Resources.Button2;
        }

        private void ButtonMouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox2.Image = Properties.Resources.Button1;
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel4.Visible = false;
            guna2Panel2.Visible = true;
            guna2Panel3.Visible = false;
            guna2Button1.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            guna2Button2.Font = new Font("Segoe UI", 11);
            guna2Button3.Font = new Font("Segoe UI", 11);
            guna2Button4.Font = new Font("Segoe UI", 11);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Panel4.Visible = false;
            guna2Panel2.Visible = false;
            guna2Panel3.Visible = true;
            guna2Button2.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            guna2Button1.Font = new Font("Segoe UI", 11);
            guna2Button3.Font = new Font("Segoe UI", 11);
            guna2Button4.Font = new Font("Segoe UI", 11);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Panel2.Visible = false;
            guna2Panel3.Visible = false;
            guna2Panel4.Visible = true;
            guna2Button1.Font = new Font("Segoe UI", 11);
            guna2Button2.Font = new Font("Segoe UI", 11);
            guna2Button4.Font = new Font("Segoe UI", 11);
            guna2Button3.Font = new Font("Segoe UI", 11, FontStyle.Bold);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
