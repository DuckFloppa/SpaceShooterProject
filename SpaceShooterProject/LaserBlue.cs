using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooterProject
{
    class LaserBlue : Laser

    {
        public override void CreateLaser(Form form)
        {
            

            if (Direction == Direction.left)
            {
                CurrentLaser.Image = Properties.Resources.PlayerLaserLeft;
            }

            if (Direction == Direction.right)
            {
                CurrentLaser.Image = Properties.Resources.PlayerLaserRight;
            }

            if (Direction == Direction.up)
            {
                CurrentLaser.Image = Properties.Resources.laserBlue01;
            }

            if (Direction == Direction.down)
            {
                CurrentLaser.Image = Properties.Resources.PlayerLaserDown;
            }

            CurrentLaser.Tag = "playerLaser";

            base.CreateLaser(form);
        }
    }
}
