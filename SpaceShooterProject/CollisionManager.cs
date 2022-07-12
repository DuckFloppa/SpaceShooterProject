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

        public CollisionManager()
        {
        }

        public void DetectCollision()
        {
            foreach (Control x in gameScreen.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "pill")
                {
                    PillHit(x);
                }



                ///add here later
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


        public void EnemyHit()
        {

        }

        public void PlayerHit()
        {

        }




    }


}
