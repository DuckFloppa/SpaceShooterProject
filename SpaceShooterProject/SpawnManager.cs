using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SpaceShooterProject
{
    public class SpawnManager
    {


        SpaceShooter gameScreen;

        Random randomSpawn = new Random();

        Timer spawnTimer = new Timer();

        Pill pill;

        bool isPill = false;

        public bool IsPill { get => isPill; set => isPill = value; }

        public SpawnManager(SpaceShooter game)
        {
            gameScreen = game;

            spawnTimer.Interval = 1000;
            spawnTimer.Tick += new EventHandler(SpawnTick);
            spawnTimer.Start();
        }

        private void SpawnTick(object sender, EventArgs e)
        {
            if(randomSpawn.Next(0,1000) < 500)
            {
                if(!IsPill)
                {
                    SpawnPill();
                }
            }

            if (randomSpawn.Next(0, 2000) < 500)
            {
                SpawnYellowUfo();
            }

        }

        private void SpawnYellowUfo()
        {
            UFO ufo = new UfoYellow();
            ufo.SpawnUfo(gameScreen);
        }



        private void SpawnPill()
        {
            pill = new Pill();

            pill.PillPosLeft = randomSpawn.Next(20, gameScreen.ClientSize.Width - pill.PillSpawn.Width);

            pill.PillPosTop = randomSpawn.Next(20, gameScreen.ClientSize.Height - pill.PillSpawn.Height);

            pill.SpawnPill(gameScreen);

            IsPill = true;
        }




    }



}
