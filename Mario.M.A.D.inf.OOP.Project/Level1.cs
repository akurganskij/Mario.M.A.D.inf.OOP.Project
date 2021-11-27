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
        PictureBox[] coordinates;
        public Level1(Form frm)
        {
            InitializeComponent();
            levelsform = frm;
            coordinates = new PictureBox[1] { pictureBox3 };
            playerMoving = new PlayerMoving(pictureBox2, timer1, 5, 75, coordinates);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.D) || e.KeyChar == 'd')
            {
                playerMoving.GoRight();
            }
            if (! jumped &&(e.KeyChar == 'W' || e.KeyChar == 'w'))
            {
                jumped = true;
                pictureBox2.Top -= 75;
                timer1.Enabled = true;
            }
            if (e.KeyChar == 'A' || e.KeyChar == 'a')
            {
                playerMoving.GoLeft();
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
    }
}
