using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Mario.M.A.D.inf.OOP.Project
{
    class PlayerMoving
    {
        private PictureBox hero, ground, door;
        private Timer timer;
        private int step, jumpheight;
        private PictureBox[] coordinates;
        private PictureBox[] coins;
        private int posLeft, posTop, height, width, rightMax;
        private bool jumped = false;
        private bool left = false, right = true;
        private int coinsamount;
        private Action complete;
        public PlayerMoving(PictureBox hero, Timer timer, int step, int jumpheight, PictureBox[] coordinates, PictureBox ground, int rightMax, PictureBox door, PictureBox[] coins, Action complete)
        {
            this.hero = hero;
            this.timer = timer;
            this.step = step;
            this.jumpheight = jumpheight;
            this.coordinates = coordinates;
            this.ground = ground;
            this.rightMax = rightMax;
            this.door = door;
            this.coins = coins;
            this.complete = complete;
            posLeft = hero.Left;
            posTop = hero.Top;
            height = hero.Height;
            width = hero.Width;
            timer.Tick += Timer_Tick;
        }
        public void GoRight()
        {
            if (left)
            {
                hero.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipY);
                right = true;
                left = false;
            }
            if (! (hero.Right + step > rightMax))
            if ((findRight().Left >= posLeft + width + step) || (findRight().Top < hero.Top))
            {
                hero.Left += step;
                posLeft += step;
                findCoin();
                findDoor();
                if (timer.Enabled == false)
                {
                    timer.Interval = 200;
                    timer.Enabled = true;
                }
            }
        }
        public void GoLeft()
        {
            if (right)
            {
                hero.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipY);
                right = false;
                left = true;
            }
            if (hero.Left - step > 0)
            {
                if ((findLeft().Right <= posLeft - step) || (findLeft().Top < hero.Top))
                {
                    hero.Left -= step;
                    posLeft -= step;
                    findCoin();
                    findDoor();
                    if (timer.Enabled == false)
                    {
                        timer.Interval = 200;
                        timer.Enabled = true;
                    }
                }
            }
        }
        public void GoUp()
        {
            
            PictureBox b = findUp();
            if (!jumped)
            {
                timer.Interval = 1500;
                jumped = true;
                if (hero.Top - jumpheight < 0)
                {
                    hero.Top = 0;
                    findCoin();
                    findDoor();
                    timer.Enabled = true;
                }
                else if((b.Location == new System.Drawing.Point(-1, -1) || b.Bottom < hero.Top - jumpheight))
                {
                    hero.Top -= jumpheight;
                    findCoin();
                    findDoor();
                    timer.Enabled = true;
                }
                else
                {
                    hero.Top = b.Bottom;
                    findCoin();
                    findDoor();
                    timer.Enabled = true;
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GoDown();
            jumped = false;
            timer.Enabled = false;
        }

        public void GoDown()
        {

            if (findDown().Location == new System.Drawing.Point(-1, -1))
            {
                hero.Top = ground.Top - jumpheight;
            }
            else
            {
                PictureBox b = findDown();
                hero.Top = b.Top - jumpheight;
            }
        }
        private PictureBox findRight()
        {
            PictureBox pBox = new PictureBox();
            pBox.Location = new System.Drawing.Point(-1, -1);
            foreach (PictureBox p in coordinates)
                if (p.Left <= hero.Right + step && p.Right > hero.Left && p.Top < hero.Bottom && p.Bottom > hero.Top)
                    pBox = p;
            return pBox;
        }
        private PictureBox findLeft()
        {
            PictureBox pBox = new PictureBox();
            pBox.Location = new System.Drawing.Point(-1, -1);
            foreach (PictureBox p in coordinates)
                if (p.Left < hero.Right && p.Right >= hero.Left - step && p.Top < hero.Bottom && p.Bottom > hero.Top)
                    pBox = p;
            return pBox;
        }
        private PictureBox findDown()
        {
            int min = 961;
            PictureBox pBox = new PictureBox();
            pBox.Location = new System.Drawing.Point(-1, -1);
            foreach (PictureBox p in coordinates)
                if (p.Top - hero.Bottom < min && hero.Bottom <= p.Top && p.Left < hero.Right && p.Right > hero.Left)
                {
                    pBox = p;
                    min = p.Top - hero.Bottom;
                }
            return pBox;
        }
        private PictureBox findUp()
        {
            int min = 961;
            PictureBox pBox = new PictureBox();
            pBox.Location = new System.Drawing.Point(-1, -1);
            foreach (PictureBox p in coordinates)
                if (hero.Top - p.Bottom < min && hero.Top >= p.Bottom && p.Left < hero.Right && p.Right > hero.Left)
                {
                    pBox = p;
                    min = hero.Top - p.Bottom;
                }
            return pBox;
        }
        private void findCoin()
        {
            foreach(PictureBox i in coins)
            {
                if(hero.Right > i.Left && hero.Left < i.Right && i.Top < hero.Bottom && i.Bottom > hero.Top && i.Visible)
                {
                    coinsamount += 1;
                    i.Visible = false;
                }
            }
        }
        private void findDoor()
        {
            if(hero.Right > door.Left && hero.Left < door.Right && door.Top < hero.Bottom && door.Bottom > hero.Top)
            {
                complete();
            }
        }
        public int getCoins()
        {
            return coinsamount;
        }
    }
}
