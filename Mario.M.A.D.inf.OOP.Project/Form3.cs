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
        PlayerMoving playerMoving;
        PictureBox[] coordinates, coins, monsters;
        public Form3(Form frm)
        {
            InitializeComponent();
            lastForm = frm;
            coordinates = new PictureBox[11] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12};
            coins = new PictureBox[3] { pictureBox13, pictureBox14, pictureBox15 };
            monsters = new PictureBox[0] { };
            playerMoving = new PlayerMoving(pictureBox17, timer1, 10, 150, coordinates, pictureBox1, Screen.PrimaryScreen.Bounds.Width, pictureBox16, coins, monsters, complete);
        }
        private void complete()
        {
            lastForm.Show();
            this.Close();
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
            pictureBox24.Location = new Point(1500, 5);
            label1.Location = new Point(1560, 11);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 level3 = new Form1();
            level3.Show();
            this.Hide();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
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
    }
}
