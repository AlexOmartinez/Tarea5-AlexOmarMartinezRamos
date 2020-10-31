using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_AlexOmarMartinez.Formularios
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPorGanancia_Click(object sender, EventArgs e)
        {
            Formularios.FormPorcentaje_de_Ganancia porcentaje_De_Ganancia = new Formularios.FormPorcentaje_de_Ganancia();
            porcentaje_De_Ganancia.Show();
        }

        private void BtnCantLtsAgua_Click(object sender, EventArgs e)
        {
            Formularios.FormCantidad_de_Litros_de_Agua cantidad_De_Litros_De_Agua = new Formularios.FormCantidad_de_Litros_de_Agua();
            cantidad_De_Litros_De_Agua.Show();
        }

        private void BtnCalNotaAprob_Click(object sender, EventArgs e)
        {
            Formularios.FormNota_para_Aprovar nota_Para_Aprovar = new Formularios.FormNota_para_Aprovar();
            nota_Para_Aprovar.Show();
        }

        private void BtnPromedio_Click(object sender, EventArgs e)
        {
            Formularios.FormPromedio promedio = new Formularios.FormPromedio();
            promedio.Show();
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            Formularios.FormFactura factura = new Formularios.FormFactura();
            factura.Show();
        }
    }
}
