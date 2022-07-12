using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooterProject
{
    
    public abstract class Laser
    {
        Direction direction;

        int laserPosLeft;
        int laserPosTop;

        int speed = 20;

        PictureBox laser = new PictureBox();

        Timer laserTimer = new Timer();

        public Direction Direction { get => direction; set => direction = value; }
        public int LaserPosLeft { get => laserPosLeft; set => laserPosLeft = value; }
        public int LaserPosTop { get => laserPosTop; set => laserPosTop = value; }
        public int Speed { get => speed; set => speed = value; }
        public PictureBox CurrentLaser { get => laser; set => laser = value; }
        public Timer LaserTimer { get => laserTimer; set => laserTimer = value; }


        public virtual void CreateLaser(Form form)
        {      
            CurrentLaser.BackColor = Color.Transparent;
            CurrentLaser.Left = LaserPosLeft;
            CurrentLaser.Top = LaserPosTop;
            CurrentLaser.BringToFront();
            form.Controls.Add(CurrentLaser);

            laserTimer.Interval = Speed;
            laserTimer.Tick += new EventHandler(LaserTick);
            laserTimer.Start();
        }

        private void LaserTick(object sender, EventArgs e)
        {

            if (Direction == Direction.left)
            {
                CurrentLaser.Left -= Speed;
            }

            if (Direction == Direction.right)
            {
                CurrentLaser.Left += Speed;
            }

            if (Direction == Direction.up)
            {
                CurrentLaser.Top -= Speed;
            }

            if (Direction == Direction.down)
            {
                CurrentLaser.Top += Speed;
            }

            if(CurrentLaser.Right < 0 || CurrentLaser.Left > 1000 || CurrentLaser.Bottom < 0 || CurrentLaser.Top > 900)
            {
                laserTimer.Stop();
                laserTimer.Dispose();
                CurrentLaser.Dispose();

                laserTimer = null; ;
                CurrentLaser = null;
            }
        }




    }





}
