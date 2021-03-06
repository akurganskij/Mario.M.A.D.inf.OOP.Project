using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Mario.M.A.D.inf.OOP.Project
{
    public partial class Form1 : Form
    {
        bool sound = true;
        public SoundPlayer player = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            this.player.LoadCompleted += new AsyncCompletedEventHandler(player_LoadCompleted);
            
        }
        

        void player_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (player.IsLoadCompleted)
            {
                try
                {
                    if (!sound)
                    {
                        this.player.PlayLooping();
                        sound = true;
                    }
                    else
                    {
                        this.player.Stop();
                        sound = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error playing sound");
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Location = new Point(750, 600);
            button3.Location = new Point(750, 450);

            button1.FlatAppearance.BorderSize = 0; 
            button1.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Levels levels = new Levels(this);
            levels.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            this.LoadAsyncSound();
        }
        public void LoadAsyncSound()
        {
            try
            {
                
                this.player.SoundLocation = @"C:\Users\Andrey Kurganskij\Desktop\ProjectOOP\music3.wav";
                this.player.LoadAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading sound");
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

            LoadAsyncSound();
            this.player.PlayLooping();
        }
    }
}
