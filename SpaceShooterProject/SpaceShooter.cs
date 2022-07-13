using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooterProject
{
    public partial class SpaceShooter : Form
    {

        SpawnManager spawnManage;
        CollisionManager collisionManage;
        EnemyMovement movementManage;


        bool goLeft, goRight, goUp, goDown;

        int playerShield = 100;

        int speed = 10;

        int score = 0;

        Direction playerDirection;
        public SpawnManager SpawnManage { get => spawnManage;}
        public int PlayerShield { get => playerShield; set => playerShield = value; }
        public int Score { get => score; set => score = value; }

        public SpaceShooter()
        {
            spawnManage = new SpawnManager(this);
            collisionManage = new CollisionManager(this);
            movementManage = new EnemyMovement(this);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameTick(object sender, EventArgs e)
        {
            Player.BringToFront();

            IsPlayerAlive();

            labelScore.Text = "Score : " + Score;

            MovePlayer();

            collisionManage.DetectCollision();

            movementManage.MoveUFO();


        }

        private void MovePlayer()
        {
            if (goLeft == true && Player.Left > 0)
            {
                Player.Left -= speed;

            }

            if (goRight == true && Player.Left + Player.Width < this.ClientSize.Width)
            {
                Player.Left += speed;
            }

            if (goUp == true && Player.Top > 0)
            {
                Player.Top -= speed;

            }

            if (goDown == true && Player.Top + Player.Height < this.ClientSize.Height - 100)
            {
                Player.Top += speed;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GetUserInput()
        {

        }

        private void IsPlayerAlive()
        {
            if(PlayerShield > 1)
            {
                ShieldsBar.Value = PlayerShield;
            }
            else
            {
                GameTimer.Stop();

                //Game Over Stuff will be here.
            }

        }

        private void Player_Click(object sender, EventArgs e)
        {

        }

        private void isKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                playerDirection = Direction.left;
                Player.Image = Properties.Resources.Left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                playerDirection = Direction.right;
                Player.Image = Properties.Resources.Right; 
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                playerDirection = Direction.up;
                Player.Image = Properties.Resources.Up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                playerDirection = Direction.down;
                Player.Image = Properties.Resources.Down;
            }
        }

        private void isKeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
              
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
                
            }

            if (e.KeyCode == Keys.Up)
            {
                
                goUp = false;
            
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
                
            }

            if (e.KeyCode == Keys.Space)
            {
                
                ShootLaser(playerDirection);
            }

        }

        private void ShootLaser(Direction direction)
        {
            Laser newLaser = new LaserBlue();

            newLaser.Direction = playerDirection;

            newLaser.LaserPosLeft = Player.Left + (Player.Width / 2);

            newLaser.LaserPosTop = Player.Top + (Player.Height / 2);

            newLaser.CreateLaser(this);
        }


    }
}
