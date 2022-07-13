using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooterProject
{
    public class CollisionManager
    {
        SpaceShooter gameScreen;

        public CollisionManager(SpaceShooter game)
        {
            gameScreen = game;
        }

        public void DetectCollision()
        {
            foreach (Control x in gameScreen.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "pill")
                {
                    PillHit(x);
                }


                foreach (Control y in gameScreen.Controls)
                {
                    if (y is PictureBox && (string)y.Tag == "playerLaser" && x is PictureBox && (string)x.Tag == "ufo")
                    {
                        EnemyHit(y, x);
                    }

                    if (y is PictureBox && (string)y.Tag == "player" && x is PictureBox && (string)x.Tag == "enemyLaser")
                    {
                        PlayerHit(y, x);
                    }

                }
                
            }


        }


        public void PillHit(Control x)
        {
            if (gameScreen.Player.Bounds.IntersectsWith(x.Bounds) && gameScreen.PlayerShield < 88)
            {
                gameScreen.Controls.Remove(x);
                ((PictureBox)x).Dispose();
                gameScreen.SpawnManage.IsPill = false;
                gameScreen.PlayerShield += 20;
            }
        }


        public void EnemyHit(Control x, Control y)
        {
            if (x.Bounds.IntersectsWith(y.Bounds))

            {
                gameScreen.Controls.Remove(x);
                ((PictureBox)x).Dispose();
                gameScreen.Controls.Remove(y);
                ((PictureBox)y).Dispose();
                gameScreen.Score += 10;
            }
        }

        public void PlayerHit(Control x, Control y)
        {
            if (x.Bounds.IntersectsWith(y.Bounds))
            {
                gameScreen.Controls.Remove(y);
                ((PictureBox)y).Dispose();
                gameScreen.PlayerShield -= 10;
            }
        }
    }
}
