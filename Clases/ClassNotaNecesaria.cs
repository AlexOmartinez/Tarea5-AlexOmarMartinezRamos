using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_AlexOmarMartinez.Clases
{
    class ClassNotaNecesaria
    {
        public void NotaN(double npe, double nse,double nte)
        {
            double nn = 65 - (npe + nse + nte);
            MessageBox.Show(nn.ToString());
        }

        public double NotaN2(double npe, double nse, double nte)
        {
            double nn = 65 - (npe + nse + nte);
            return nn;
        }
    }
}
