using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Septiembre4.modelo
{
    class Moneda
    {
        private int y;
        private int x;

        public int VelocidadX { set; get;} = -5; 
        public int VelocidadY { set; get;} = -5;

        public int AceleracionX { set; get;} = 0; // no esta acelerando.
        public int AceleracionY { set; get; } = 0;

        public PictureBox imagen {set; get; } = new PictureBox();

        public bool Activo { set; get;} = false;

        // propiedad expandida.
        public int X
        {
            set { x = value; Mover(); }
            get { return x; }
        }


        public int Y
        {
            set { y = value; Mover(); }
            get { return y; }
        }

        public void DibujaMe(Form1 formulario)
        {
            
            imagen.Image = global::Septiembre4.Properties.Resources._009_insert_coin;
            imagen.Size = new System.Drawing.Size(64, 64);
            imagen.Location = new System.Drawing.Point(X, Y);
            imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            formulario.Controls.Add(imagen);
            Activo=true;
        }

        public void Actualizar()
        {
            if(!Activo)
            {
                return;
            }
            X=X+VelocidadX;
            Y=Y+VelocidadY;
        }

        private void Mover()
        {
            imagen.Location = new System.Drawing.Point(X, Y);
        }
        public bool ColisionX()
        {
            if(X<64)
            {
                return true;
            }
            if(X>8*64)
            {
                return true;
            }
            return false;
        }
        public int ColisionY(Barra barra)
        {
            if (Y < 64)
            {
                return 1;
            }

            if(Y > 5*64 && Y<5*64+40 && X>barra.X-64 && X<barra.X+128)
            {
                return -1;
            }
            return 0;
        }
       

    }
}
