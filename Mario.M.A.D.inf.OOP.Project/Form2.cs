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
        PlayerMoving playerMoving;
        PictureBox[] coordinates, coins, monsters;
        public Level2(Form frm)
        {
            InitializeComponent();
            lastForm = frm;
            coordinates = new PictureBox[9] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10};
            coins = new PictureBox[3] { pictureBox11, pictureBox12, pictureBox21 };
            monsters = new PictureBox[0] { };
            playerMoving = new PlayerMoving(pictureBox17, timer1, 10, 150, coordinates, pictureBox1, Screen.PrimaryScreen.Bounds.Width, pictureBox18, coins, monsters, complete);
        }
        private void complete()
        {
            lastForm.Show();
            this.Close();
        }

        private void Level2_Load(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(100, 720);
            pictureBox3.Location = new Point(450, 570);
            pictureBox4.Location = new Point(50, 350);
            pictureBox5.Location = new Point(550, 420);
            pictureBox6.Location = new Point(350, 870);
            pictureBox7.Location = new Point(920, 650);
            pictureBox8.Location = new Point(850, 270);
            pictureBox9.Location = new Point(1350, 400);
            pictureBox10.Location = new Point(1350, 750);
            pictureBox11.Location = new Point(50, 220);
            pictureBox12.Location = new Point(885, 170);
            pictureBox21.Location = new Point(1375, 690);
            pictureBox18.Location = new Point(940, 495);
            pictureBox24.Location = new Point(1500, 5);
            label1.Location = new Point(1560, 11);

        }

        private void Level2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                playerMoving.GoUp();
                label1.Text = playerMoving.getCoins().ToString();
            }
            if (e.KeyCode == Keys.A)
            {
                playerMoving.GoLeft();
                label1.Text = playerMoving.getCoins().ToString();
            }
            if (e.KeyCode == Keys.D)
            {
                playerMoving.GoRight();
                label1.Text = playerMoving.getCoins().ToString();
            }
            if (e.KeyCode == Keys.Space)
            {
                playerMoving.Hit();
                label1.Text = playerMoving.getCoins().ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 level3 = new Form1();
            level3.Show();
            this.Hide();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
    }

}
