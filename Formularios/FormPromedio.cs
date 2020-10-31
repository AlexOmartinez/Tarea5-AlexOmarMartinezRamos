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
    public partial class FormPromedio : Form
    {
        Clases.ClassPromedioGeneral h = new Clases.ClassPromedioGeneral();
        public FormPromedio()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text.Trim().Length == 0)
            {
                h.MsgWarning("El Campo Nombre del Estudiante es Requerido");
                TxtNombre.Focus();
                return;
            }

            if (TxtNota1.Text.Trim().Length == 0)
            {
                h.MsgWarning("El Campo Nota 1 es Requerido");
                TxtNota1.Focus();
                return;
            }

            if (TxtNota2.Text.Trim().Length == 0)
            {
                h.MsgWarning("El Campo Nota 2 es Requerido");
                TxtNota2.Focus();
                return;
            }

            if (TxtNota3.Text.Trim().Length == 0)
            {
                h.MsgWarning("El Campo Nota 3 es Requerido");
                TxtNota3.Focus();
                return;
            }

            if (TxtNota4.Text.Trim().Length == 0)
            {
                h.MsgWarning("El Campo Nota 4 es Requerido");
                TxtNota4.Focus();
                return;
            }

            string nombre, n1, n2, n3, n4;
            nombre = TxtNombre.Text.Trim();
            n1 = TxtNota1.Text.Trim();
            n2 = TxtNota2.Text.Trim();
            n3 = TxtNota3.Text.Trim();
            n4 = TxtNota4.Text.Trim();
            DgvPromedio.Rows.Add(nombre, n1, n2, n3, n4);

            double pg;
            double no1 = Convert.ToDouble(TxtNota1.Text);
            double no2 = Convert.ToDouble(TxtNota2.Text);
            double no3 = Convert.ToDouble(TxtNota3.Text);
            double no4 = Convert.ToDouble(TxtNota4.Text);
           
            pg = (no1 + no2 + no3 + no4) / 4;

            ClearForm();

            TxtPromedioGeneral.Text = pg.ToString();
            

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            ClearForm();  
        }

        private void ClearForm()
        {
            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
                TxtNombre.Focus();
            }
        }
    }
}
