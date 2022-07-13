using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooterProject
{
    class LaserRed : Laser
    {

        public override void CreateLaser(Form form)
        {
            if (Direction == Direction.left)
            {
                CurrentLaser.Image = Properties.Resources.EnemyLaserLeft;
            }

            if (Direction == Direction.right)
            {
                CurrentLaser.Image = Properties.Resources.EnemyLaserRight;
            }

            if (Direction == Direction.up)
            {
                CurrentLaser.Image = Properties.Resources.laserRed01;
            }

            if (Direction == Direction.down)
            {
                CurrentLaser.Image = Properties.Resources.EnemyLaserDown;
            }

            CurrentLaser.Tag = "enemyLaser";

            
            base.CreateLaser(form);
        }

    }
}
