using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SpaceShooterProject
{
    public abstract class UFO
    {

        PictureBox ufo;

        int ufoPosleft;
        int ufoPosTop;

        
        public PictureBox UfoSpawn { get => ufo; set => ufo = value; }
        public int UfoPosleft { get => ufoPosleft; set => ufoPosleft = value; }
        public int UfoPosTop { get => ufoPosTop; set => ufoPosTop = value; }

        public virtual void SpawnUfo(Form form)
        {
            ufo = new PictureBox();
            UfoSpawn.Tag = "ufo";
            UfoSpawn.SizeMode = PictureBoxSizeMode.AutoSize;
        }

    }
}
