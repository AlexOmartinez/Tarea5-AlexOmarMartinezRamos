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
    public partial class FormCantidad_de_Litros_de_Agua : Form
    {
        Clases.ClassLitrosdeAgua h = new Clases.ClassLitrosdeAgua();
        public FormCantidad_de_Litros_de_Agua()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCLNLT.Clear();
            TxtTTMC.Clear();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtTTMC.Text.Trim().Length == 0)
            {
                MessageBox.Show("El Campo es Requerido");
                TxtTTMC.Focus();
                return;
            }

            double m, resp;

            m = Convert.ToDouble(TxtTTMC.Text);

            resp = m * 1000;

            TxtCLNLT.Text = h.Tanque(m, resp).ToString();
        }
    }
}
