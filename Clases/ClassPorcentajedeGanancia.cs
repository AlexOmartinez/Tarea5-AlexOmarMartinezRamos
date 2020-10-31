using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_AlexOmarMartinez.Clases
{
    class ClassPorcentajedeGanancia
    {
        public void PorcentajeG(double pc, double pv)
        {
            double pg=(pc/pv)*100;
            MessageBox.Show(pg.ToString());
        }
        public double PorcentajeG2(double pc, double pv)
        {
            double pg = (pc / pv) * 100;
            return pg;
        }
    }
}
