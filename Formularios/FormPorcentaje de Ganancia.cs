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
    public partial class FormPorcentaje_de_Ganancia : Form
    {
        Clases.ClassPorcentajedeGanancia PG = new Clases.ClassPorcentajedeGanancia();
        public FormPorcentaje_de_Ganancia()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
 
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtPreciodeCosto.Clear();
            TxtPorcentajeGanancia.Clear();
            TxtPreciodeVenta.Clear();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtPreciodeCosto.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Precio de Costo");
                TxtPreciodeCosto.Focus();
                return;
            }

            if (TxtPreciodeVenta.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Precio de Venta");
                TxtPreciodeVenta.Focus();
                return;
            }

            double pc = Convert.ToDouble(TxtPreciodeCosto.Text);
            double pv = Convert.ToDouble(TxtPreciodeVenta.Text);

            TxtPorcentajeGanancia.Text = PG.PorcentajeG2(pc, pv).ToString();
        }

        private void FormPorcentaje_de_Ganancia_Load(object sender, EventArgs e)
        {

        }
    }
}
