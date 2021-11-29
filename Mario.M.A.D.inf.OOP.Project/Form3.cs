using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mario.M.A.D.inf.OOP.Project
{
    public partial class Form3 : Form
    {
        Form lastForm;
        public Form3(Form frm)
        {
            InitializeComponent();
            lastForm = frm;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(350, 880);
            pictureBox3.Location = new Point(600, 720);
            pictureBox4.Location = new Point(850, 590);
            pictureBox5.Location = new Point(1100, 480);
            pictureBox6.Location = new Point(1500, 380);
            pictureBox7.Location = new Point(1680, 280);
            pictureBox8.Location = new Point(50, 600);
            pictureBox9.Location = new Point(450, 570);
            pictureBox10.Location = new Point(630, 420);
            pictureBox11.Location = new Point(700, 180);
            pictureBox12.Location = new Point(550, 290);
            pictureBox13.Location = new Point(1800, 960);
            pictureBox14.Location = new Point(80, 530);
            pictureBox15.Location = new Point(720, 120);
            pictureBox16.Location = new Point(1700, 70);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 level3 = new Form1();
            level3.Show();
            this.Hide();
        }
    }
}
