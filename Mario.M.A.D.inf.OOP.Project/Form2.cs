using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mario.M.A.D.inf.OOP.Project
{
    public partial class Level2 : Form
    {
        Form lastForm;
        public Level2(Form frm)
        {
            InitializeComponent();
            lastForm = frm;
        }

        private void Level2_Load(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(100, 700);
            pictureBox3.Location = new Point(300, 500);
            pictureBox4.Location = new Point(50, 250);
            pictureBox5.Location = new Point(550, 320);
            pictureBox6.Location = new Point(350, 870);
            pictureBox7.Location = new Point(920, 650);
            pictureBox8.Location = new Point(850, 200);
            pictureBox9.Location = new Point(1350, 400);
            pictureBox10.Location = new Point(1350, 750);
            pictureBox11.Location = new Point(50, 190);
            pictureBox12.Location = new Point(885, 140);
            pictureBox21.Location = new Point(1375, 690);
            pictureBox18.Location = new Point(940, 495);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 level3 = new Form1();
            level3.Show();
            this.Hide();
        }

      
    }

}
