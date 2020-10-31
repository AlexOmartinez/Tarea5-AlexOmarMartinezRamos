using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_AlexOmarMartinez.Formularios
{
    public partial class FormNota_para_Aprovar : Form
    {
        Clases.ClassNotaNecesaria NN = new Clases.ClassNotaNecesaria();
        public FormNota_para_Aprovar()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtNombreEstudiante.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el Nombre del Estudiante");
                TxtNombreEstudiante.Focus();
                return;
            }

            if (TxtNotaPE.Text.Trim().Length==0)
            {
                MessageBox.Show("Ingrese la Nota del Primer Examen");
                TxtNotaPE.Focus();
                return;
            }

            if (TxtNotaSE.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese la Nota del Segundo Examen");
                TxtNotaSE.Focus();
                return;
            }

            if (TxtNotaTE.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese la Nota del Tercer Examen");
                TxtNotaTE.Focus();
                return;
            }

            double npe = Convert.ToDouble(TxtNotaPE.Text);
            double nse = Convert.ToDouble(TxtNotaSE.Text);
            double nte = Convert.ToDouble(TxtNotaTE.Text);

            TxtNotaNA.Text = NN.NotaN2(npe, nse, nte).ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNotaNA.Clear();
            TxtNombreEstudiante.Clear();
            TxtNotaPE.Clear();
            TxtNotaSE.Clear();
            TxtNotaTE.Clear();
        }
    }
}
