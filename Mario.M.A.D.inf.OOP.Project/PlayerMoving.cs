using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Mario.M.A.D.inf.OOP.Project
{
    class PlayerMoving
    {
        private PictureBox hero;
        private Timer timer;
        private int step, jumpheight;
        private PictureBox[] coordinates;
        private int posLeft, posTop, height, width;
        public PlayerMoving(PictureBox hero, Timer timer, int step, int jumpheight, PictureBox[] coordinates)
        {
            this.hero = hero;
            this.timer = timer;
            this.step = step;
            this.jumpheight = jumpheight;
            this.coordinates = coordinates;
            posLeft = hero.Left;
            posTop = hero.Top;
            height = hero.Height;
            width = hero.Width;
        }
        public void GoRight()
        {
            if((findLeft(posLeft + width + step).Left > posLeft + width + step) || (findLeft(posLeft + width + step).Top < posTop))
            {
                hero.Left += step;
                posLeft += step;
            }
        }
        public void GoLeft()
        {
            if ((posLeft - step > 0)&&((findRight(posLeft + width + step).Left < posLeft + width + step) || (findRight(posLeft + width).Top < posTop)))
            {
                hero.Left -= step;
                posLeft -= step;
            }
        }
        public void GoUp()
        {

        }
        private PictureBox findLeft(int x, int w = 0)
        {
            PictureBox pBox = new PictureBox();
            pBox.Location = new System.Drawing.Point(-1, -1);
            foreach (PictureBox p in coordinates) 
                if (p.Left + w <= x && p.Right >= x) 
                    pBox = p;
            return pBox;
        }
        private PictureBox findRight(int x, int w = 0)
        {
            PictureBox pBox = new PictureBox();
            pBox.Location = new System.Drawing.Point(-1, -1);
            foreach (PictureBox p in coordinates)
                if (p.Right + w <= x && p.Left >= x)
                    pBox = p;
            return pBox;
        }
    }
}
