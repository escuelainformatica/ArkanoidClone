using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Septiembre4.modelo
{
    class Barra
    {
        public PictureBox imagen { set; get;} = new PictureBox();
        public int X { set; get;}

        public void DibujaMe(Form1 formulario)
        {
            imagen.Image = global::Septiembre4.Properties.Resources._033_tetris;
            imagen.Size = new System.Drawing.Size(128, 40);
            imagen.Location = new System.Drawing.Point(X, 6*64);
            imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            formulario.Controls.Add(imagen);
        }

        public void MoverIzquierda()
        {
            X=X-30;
            if(X<0)
            {
                X=0;
            }

            ActualizarPosicion();

        }
        public void MoverDerecha()
        {
            X=X+30;
            if (X > 64 * 8)
            {
                X = 64 * 8;
            }
            ActualizarPosicion();
        }
        public void ActualizarPosicion()
        {
            imagen.Location = new System.Drawing.Point(X, 6*64);
        }

    }
}
