using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mario.M.A.D.inf.OOP.Project
{
    public partial class Levels : Form
    {
        int imagenum = 0;
        Form welcomeform = new Form();
        public Levels(Form frm)
        {
            InitializeComponent();
            welcomeform = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Level1 level1 = new Level1(this);
            level1.Show(this);
            this.Hide();
        }

        private void Levels_Load(object sender, EventArgs e)
        {
            button4.Location = new Point(80, 950);
            button1.Location = new Point(1350, 950);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Level2 level2 = new Level2(this);
            level2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 level3 = new Form3(this);
            level3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 level3 = new Form1();
            level3.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Level1 level3 = new Level1(this);
            level3.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            imagenum++;
            imagenum %= 3;
            switch(imagenum)
            {
                case 0: pictureBox1.Image = Properties.Resources.lvl1; break;
                case 1: pictureBox1.Image = Properties.Resources.lvl2; break;
                case 2: pictureBox1.Image = Properties.Resources.lvl3; break;
            }
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            imagenum--;
            if (imagenum < 0) imagenum = 3 + imagenum;
            imagenum %= 3;
            switch (imagenum)
            {
                case 0: pictureBox1.Image = Properties.Resources.lvl1; break;
                case 1: pictureBox1.Image = Properties.Resources.lvl2; break;
                case 2: pictureBox1.Image = Properties.Resources.lvl3; break;
            }
        }
    }
}
