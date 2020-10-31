using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_AlexOmarMartinez.Clases
{
    class Helpers
    {
        public void MsgWarning(string msg)
        {
            MessageBox.Show(msg, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void AlertNotNumber(string str)
        {
            double a;
            if (! double.TryParse(str, out a))
            {
                MsgWarning("El Valor Debe Ser Numerico");
            }
        }

        public string CheckIfIsNumber(string str)
        {
            string resp = "";
            double b;
            if (double.TryParse(str, out b))
            {
                resp = "S";
            }
            else
            {
                resp = "N";
            }

            return resp;
        }

        public double ReturnsNumber(string str)
        {
            double value = 0;
            
            if (double.TryParse(str, out value))
            {
                value = Convert.ToDouble(str);
            }
            return value;
        }

    }
}
