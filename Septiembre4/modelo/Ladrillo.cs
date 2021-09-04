using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Septiembre4.modelo
{
    class Ladrillo
    {
        public int X { set; get;}
        public int Y { set; get;}

        public void DibujaMe(Form1 formulario)
        {
            PictureBox imagen=new PictureBox();
            imagen.Image= global::Septiembre4.Properties.Resources._020_brickwall;
            imagen.Size = new System.Drawing.Size(64, 64);
            imagen.Location = new System.Drawing.Point(X*64, Y*64);
            imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            formulario.Controls.Add(imagen);

        }
    }
}
