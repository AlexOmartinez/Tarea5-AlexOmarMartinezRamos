namespace Tarea5_AlexOmarMartinez.Formularios
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnPorGanancia = new System.Windows.Forms.Button();
            this.BtnFactura = new System.Windows.Forms.Button();
            this.BtnPromedio = new System.Windows.Forms.Button();
            this.BtnCalNotaAprob = new System.Windows.Forms.Button();
            this.BtnCantLtsAgua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Aqua;
            this.BtnSalir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(308, 180);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(56, 27);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnPorGanancia
            // 
            this.BtnPorGanancia.BackColor = System.Drawing.Color.Aqua;
            this.BtnPorGanancia.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPorGanancia.Location = new System.Drawing.Point(12, 21);
            this.BtnPorGanancia.Name = "BtnPorGanancia";
            this.BtnPorGanancia.Size = new System.Drawing.Size(104, 68);
            this.BtnPorGanancia.TabIndex = 1;
            this.BtnPorGanancia.Text = "Porcentaje de Ganancia";
            this.BtnPorGanancia.UseVisualStyleBackColor = false;
            this.BtnPorGanancia.Click += new System.EventHandler(this.BtnPorGanancia_Click);
            // 
            // BtnFactura
            // 
            this.BtnFactura.BackColor = System.Drawing.Color.Aqua;
            this.BtnFactura.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFactura.Location = new System.Drawing.Point(181, 93);
            this.BtnFactura.Name = "BtnFactura";
            this.BtnFactura.Size = new System.Drawing.Size(107, 71);
            this.BtnFactura.TabIndex = 2;
            this.BtnFactura.Text = "Factura";
            this.BtnFactura.UseVisualStyleBackColor = false;
            this.BtnFactura.Click += new System.EventHandler(this.BtnFactura_Click);
            // 
            // BtnPromedio
            // 
            this.BtnPromedio.BackColor = System.Drawing.Color.Aqua;
            this.BtnPromedio.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPromedio.Location = new System.Drawing.Point(71, 93);
            this.BtnPromedio.Name = "BtnPromedio";
            this.BtnPromedio.Size = new System.Drawing.Size(104, 71);
            this.BtnPromedio.TabIndex = 3;
            this.BtnPromedio.Text = "Promedio";
            this.BtnPromedio.UseVisualStyleBackColor = false;
            this.BtnPromedio.Click += new System.EventHandler(this.BtnPromedio_Click);
            // 
            // BtnCalNotaAprob
            // 
            this.BtnCalNotaAprob.BackColor = System.Drawing.Color.Aqua;
            this.BtnCalNotaAprob.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalNotaAprob.Location = new System.Drawing.Point(246, 22);
            this.BtnCalNotaAprob.Name = "BtnCalNotaAprob";
            this.BtnCalNotaAprob.Size = new System.Drawing.Size(118, 65);
            this.BtnCalNotaAprob.TabIndex = 4;
            this.BtnCalNotaAprob.Text = "Calcular la Nota para Aprobar";
            this.BtnCalNotaAprob.UseVisualStyleBackColor = false;
            this.BtnCalNotaAprob.Click += new System.EventHandler(this.BtnCalNotaAprob_Click);
            // 
            // BtnCantLtsAgua
            // 
            this.BtnCantLtsAgua.BackColor = System.Drawing.Color.Aqua;
            this.BtnCantLtsAgua.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCantLtsAgua.Location = new System.Drawing.Point(122, 21);
            this.BtnCantLtsAgua.Name = "BtnCantLtsAgua";
            this.BtnCantLtsAgua.Size = new System.Drawing.Size(118, 67);
            this.BtnCantLtsAgua.TabIndex = 5;
            this.BtnCantLtsAgua.Text = "Cantidad de Litros de Agua";
            this.BtnCantLtsAgua.UseVisualStyleBackColor = false;
            this.BtnCantLtsAgua.Click += new System.EventHandler(this.BtnCantLtsAgua_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(372, 214);
            this.Controls.Add(this.BtnCantLtsAgua);
            this.Controls.Add(this.BtnCalNotaAprob);
            this.Controls.Add(this.BtnPromedio);
            this.Controls.Add(this.BtnFactura);
            this.Controls.Add(this.BtnPorGanancia);
            this.Controls.Add(this.BtnSalir);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnPorGanancia;
        private System.Windows.Forms.Button BtnFactura;
        private System.Windows.Forms.Button BtnPromedio;
        private System.Windows.Forms.Button BtnCalNotaAprob;
        private System.Windows.Forms.Button BtnCantLtsAgua;
    }
}