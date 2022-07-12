using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooterProject
{
    class Pill
    {
        PictureBox pillSpawn = new PictureBox();

        bool pillExist;

        int pillPosLeft;
        int pillPosTop;

        public PictureBox PillSpawn { get => pillSpawn; set => pillSpawn = value; }
        public bool PillExist { get => pillExist; set => pillExist = value; }
        public int PillPosLeft { get => pillPosLeft; set => pillPosLeft = value; }
        public int PillPosTop { get => pillPosTop; set => pillPosTop = value; }

        public void SpawnPill (Form form)
        {
            PillSpawn.Image = Properties.Resources.pill_blue;
            PillSpawn.SizeMode = PictureBoxSizeMode.AutoSize;
            PillSpawn.Tag = "pill";
            PillSpawn.Left = PillPosLeft;
            PillSpawn.Top = PillPosTop;

            form.Controls.Add(PillSpawn);
            PillSpawn.BringToFront();



        }


    }
}
