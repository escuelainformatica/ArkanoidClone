using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septiembre4.modelo
{
    class Escenario
    {
        public static void Dibujame(Form1 form)
        {
            for (int x = 0; x < 10; x++)
            {
                Ladrillo l1 = new Ladrillo();
                l1.X = x;
                l1.Y = 0;
                l1.DibujaMe(form);
            }

            /*for (int x = 0; x < 10; x++)
            {
                Ladrillo l1 = new Ladrillo();
                l1.X = x;
                l1.Y = 6;
                l1.DibujaMe(form);
            }*/

            for (int y = 1; y < 6; y++)
            {
                Ladrillo l1 = new Ladrillo();
                l1.X = 0;
                l1.Y = y;
                l1.DibujaMe(form);
            }
            for (int y = 1; y < 6; y++)
            {
                Ladrillo l1 = new Ladrillo();
                l1.X = 9;
                l1.Y = y;
                l1.DibujaMe(form);
            }
        }
    }
}
