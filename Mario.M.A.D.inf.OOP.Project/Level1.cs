using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mario.M.A.D.inf.OOP.Project
{
    public partial class Level1 : Form
    {
        bool jumped = false;
        Form levelsform = new Form();
        public Level1(Form frm)
        {
            InitializeComponent();
            levelsform = frm;
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(10, 50);
        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.D) || e.KeyChar == 'd')
            {
                pictureBox2.Left += 5;
            }
            if (! jumped &&(e.KeyChar == 'W' || e.KeyChar == 'w'))
            {
                jumped = true;
                pictureBox2.Top -= 75;
                timer1.Enabled = true;
            }
            if (e.KeyChar == 'A' || e.KeyChar == 'a')
            {
                pictureBox2.Left -= 5;
            }
        }

        private void Level1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            jumped = false;
            pictureBox2.Top += 75;
            timer1.Enabled = false;
        }

        private void Level1_Load(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(50, 150);
            pictureBox4.Location = new Point(350, 800);
            pictureBox5.Location = new Point(550, 700);
            pictureBox6.Location = new Point(1650, 700);
            pictureBox7.Location = new Point(1500, 800);
            pictureBox8.Location = new Point(200, 250);
            pictureBox9.Location = new Point(850, 700);
            pictureBox10.Location = new Point(1450, 600);
            pictureBox11.Location = new Point(1300, 475);
            pictureBox12.Location = new Point(1150, 350);
            pictureBox13.Location = new Point(800, 230);
            pictureBox14.Location = new Point(600, 350);
            pictureBox15.Location = new Point(400, 250);
            pictureBox16.Location = new Point(50, 500);
            pictureBox17.Location = new Point(400, 450);

        }
    }
}
