using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooterProject
{
    public class EnemyMovement
    {
        SpaceShooter gameScreen;

        Timer gameTime = new Timer();

        int speed = 1; //speed of timer, not really anything big LOL



        public EnemyMovement(SpaceShooter game)
        {

            gameScreen = game;
            gameTime.Interval = 20000;
            gameTime.Start();
            gameTime.Tick += new EventHandler(GameTick);



        }

        public void MoveUFO()
        {

            foreach (Control x in gameScreen.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ufo")
                {
                    if (x.Left > gameScreen.Player.Left)
                    {
                        x.Left -= speed; 
                    }

                    if (x.Left < gameScreen.Player.Left)
                    {
                        x.Left += speed;
                    }

                    if (x.Top > gameScreen.Player.Top)
                    {
                        x.Top -= speed;
                    }

                    if (x.Top < gameScreen.Player.Top)
                    {
                        x.Top += speed;
                    }
                }
            }
        }








        private void GameTick(object sender, EventArgs e)
        {
            speed++;
        }




    }


}
