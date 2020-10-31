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
    public partial class FormFactura : Form
    {
        Clases.Helpers h = new Clases.Helpers();
        public FormFactura()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text.Trim().Length==0)
            {
                h.MsgWarning("El Campo Codigo es Requerido");
                TxtCodigo.Focus();
                return;
            }

            if (TxtNombre.Text.Trim().Length == 0)
            {
                h.MsgWarning("El Campo Nombre del Producto es Requerido");
                TxtNombre.Focus();
                return;
            }

            if (TxtDescripcion.Text.Trim().Length == 0)
            {
                h.MsgWarning("El Campo Descripcion es Requerido");
                TxtDescripcion.Focus();
                return;
            }

            if (h.CheckIfIsNumber(TxtPrecioUnitario.Text.Trim())=="N")
            {
                h.MsgWarning("El Valor Ingresado en Precio Unitario Debe de Ser Numerico");
                TxtPrecioUnitario.Focus();
                return;
            }

            string codigo, nombre, descrip, preciounit;
            codigo = TxtCodigo.Text.Trim();
            nombre = TxtNombre.Text.Trim();
            descrip = TxtDescripcion.Text.Trim();
            preciounit=TxtPrecioUnitario.Text.Trim();
            DgvFactura.Rows.Add(codigo, nombre, descrip, preciounit);

            double subtotal = (h.ReturnsNumber(TxtSubTotal.Text) + h.ReturnsNumber(preciounit));
            double isv = (subtotal * 0.15);
            double tp = subtotal + isv;
            ClearForm();
            TxtSubTotal.Text = subtotal.ToString();
            TxtISV.Text = isv.ToString();
            TxtTotalaPagar.Text = tp.ToString();


        }

        private void ClearForm()
        {
            foreach(TextBox Txt in this.Controls.OfType<TextBox>())
            {
                Txt.Clear();
                TxtCodigo.Focus();
            }

        }

        private void TxtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioUnitario.Text.Trim().Length > 0)
            {
                h.AlertNotNumber(TxtPrecioUnitario.Text.Trim());
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

    }
}
