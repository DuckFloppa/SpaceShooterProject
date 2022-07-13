using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooterProject
{
    class UfoYellow : UFO
    {
        Laser laserDown;
        Laser laserUp;
        Laser laserLeft;
        Laser laserRight;

        Timer shootTimer = new Timer();

        Form gameScreen;

        Random randomNum = new Random();



        public override void SpawnUfo(Form form)
        {
            base.SpawnUfo(form);

            UfoSpawn.Left = randomNum.Next(-200, 1200);
            UfoSpawn.Top = randomNum.Next(-100, 0);
            gameScreen = form;
            UfoSpawn.Image = Properties.Resources.enemyRed1;
            gameScreen.Controls.Add(UfoSpawn);
            UfoSpawn.BringToFront();

            shootTimer.Tick += new EventHandler(ShootTick);
            shootTimer.Interval = 1000;
            shootTimer.Start();

        }

        private void ShootTick(object sender, EventArgs e)
        {

            if (!gameScreen.Controls.Contains(UfoSpawn))
            {

                laserUp = null;
                laserDown = null;
                laserLeft = null;
                laserRight = null;
                shootTimer.Stop();
            }
            else
            {
                laserUp = new LaserRed();
                laserDown = new LaserRed();
                laserLeft = new LaserRed();
                laserRight = new LaserRed();


                laserUp.Direction = Direction.up;
                laserUp.LaserPosLeft = UfoSpawn.Left + (UfoSpawn.Width / 2);
                laserUp.LaserPosTop = UfoSpawn.Top + (UfoSpawn.Height / 2);
                laserUp.CreateLaser(gameScreen);

                laserDown.Direction = Direction.down;
                laserDown.LaserPosLeft = UfoSpawn.Left + (UfoSpawn.Width / 2);
                laserDown.LaserPosTop = UfoSpawn.Top + (UfoSpawn.Height / 2);
                laserDown.CreateLaser(gameScreen);

                laserLeft.Direction = Direction.left;
                laserLeft.LaserPosLeft = UfoSpawn.Left + (UfoSpawn.Width / 2);
                laserLeft.LaserPosTop = UfoSpawn.Top + (UfoSpawn.Height / 2);
                laserLeft.CreateLaser(gameScreen);

                laserRight.Direction = Direction.right;
                laserRight.LaserPosLeft = UfoSpawn.Left + (UfoSpawn.Width / 2);
                laserRight.LaserPosTop = UfoSpawn.Top + (UfoSpawn.Height / 2);
                laserRight.CreateLaser(gameScreen);
            }

            }

        }
}
