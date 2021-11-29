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
        PlayerMoving playerMoving;
        PictureBox[] coordinates, coins;
        public Level1(Form frm)
        {
            InitializeComponent();
            levelsform = frm;
            coordinates = new PictureBox[15] { pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17 };
            coins = new PictureBox[3] { pictureBox19, pictureBox20, pictureBox21 };
            playerMoving = new PlayerMoving(pictureBox2, timer1, 10, 150, coordinates, pictureBox1, Screen.PrimaryScreen.Bounds.Width, pictureBox18, coins, complete);
        }
        private void complete()
        {
            levelsform.Show();
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void Level1_Load(object sender, EventArgs e)
        {
            button1.TabIndex = 3;
            pictureBox3.Location = new Point(50, 150);
            pictureBox4.Location = new Point(350, 800);
            pictureBox5.Location = new Point(550, 700);
            pictureBox6.Location = new Point(1700, 700);
            pictureBox7.Location = new Point(1500, 800);
            pictureBox8.Location = new Point(200, 250);
            pictureBox9.Location = new Point(900, 700);
            pictureBox10.Location = new Point(1450, 600);
            pictureBox11.Location = new Point(1300, 475);
            pictureBox12.Location = new Point(1150, 350);
            pictureBox13.Location = new Point(800, 230);
            pictureBox14.Location = new Point(600, 350);
            pictureBox15.Location = new Point(400, 250);
            pictureBox16.Location = new Point(50, 500);
            pictureBox17.Location = new Point(400, 450);
            pictureBox18.Location = new Point(50, 0);
            pictureBox19.Location = new Point(920, 645);
            pictureBox20.Location = new Point(50, 445);
            pictureBox21.Location = new Point(1720, 645);
            pictureBox22.Location = new Point(640, 615);
            pictureBox23.Location = new Point(940, 145);

        }
        private void Level1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up || e.KeyCode == Keys.W)
            {
                playerMoving.GoUp();
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                playerMoving.GoLeft();
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                playerMoving.GoRight();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void Level1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 level3 = new Form1();
            level3.Show();
            this.Hide();
        }
    }
}
