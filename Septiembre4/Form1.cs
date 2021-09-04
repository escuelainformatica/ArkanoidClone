using Septiembre4.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Septiembre4
{
    public partial class Form1 : Form
    {
        private Moneda moneda = new Moneda();
        private Barra barra=new Barra();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Escenario.Dibujame(this);                        
            moneda.X=200;
            moneda.Y=100;
            moneda.DibujaMe(this);
            barra.X=200;
            barra.DibujaMe(this);

        }

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            // X o Y <0
            if(moneda.ColisionX())
            {
                moneda.VelocidadX=-moneda.VelocidadX;                
            }
            if (moneda.ColisionY(barra)==1)
            {
                moneda.VelocidadY = 5;
            }
            if (moneda.ColisionY(barra) == -1)
            {
                moneda.VelocidadY = -5;
            }
            moneda.Actualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            barra.MoverIzquierda();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            barra.MoverDerecha();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            barra.Mover(e.X);
        }
    }
}
