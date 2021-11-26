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
    }
}
