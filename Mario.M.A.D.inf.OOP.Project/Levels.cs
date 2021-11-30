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
            pictureBox1.Width = 1580;
            pictureBox1.Height = 840;
            pictureBox1.Location = new Point(170, 50);
            button3.Location = new Point(30, 50);
            button3.Width = 120;
            button3.Height = 840;
            button2.Location = new Point(1770, 50);
            button2.Width = 120;
            button2.Height = 840;

            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;

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
                case 0: pictureBox1.BackgroundImage = Properties.Resources.lvl11; break;
                case 1: pictureBox1.BackgroundImage = Properties.Resources.lvl21; break;
                case 2: pictureBox1.BackgroundImage = Properties.Resources.lvl31; break;
            }
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            imagenum--;
            if (imagenum < 0) imagenum = 3 + imagenum;
            imagenum %= 3;
            switch (imagenum)
            {
                case 0: pictureBox1.BackgroundImage = Properties.Resources.lvl11; break;
                case 1: pictureBox1.BackgroundImage = Properties.Resources.lvl21; break;
                case 2: pictureBox1.BackgroundImage = Properties.Resources.lvl31; break;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            switch (imagenum)
            {
                case 0: { 
                        Level1 lvl1 = new Level1(this);
                        lvl1.Show();
                        this.Hide();
                        break; 
                    }
                case 1:
                    {
                        Level2 lvl2 = new Level2(this);
                        lvl2.Show();
                        this.Hide();
                        break;
                    }
                case 2:
                    {
                        Form3 lvl3 = new Form3(this);
                        lvl3.Show();
                        this.Hide();
                        break;
                    }
            }
        }

       
    }
}
