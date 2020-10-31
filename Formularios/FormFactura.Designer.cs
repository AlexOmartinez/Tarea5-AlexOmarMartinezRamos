namespace Tarea5_AlexOmarMartinez.Formularios
{
    partial class FormFactura
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
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DgvFactura = new System.Windows.Forms.DataGridView();
            this.DcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TxtISV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTotalaPagar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSalir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(742, 475);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(73, 30);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(165, 55);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(92, 25);
            this.TxtCodigo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese los Datos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPrecioUnitario
            // 
            this.TxtPrecioUnitario.Location = new System.Drawing.Point(165, 141);
            this.TxtPrecioUnitario.Name = "TxtPrecioUnitario";
            this.TxtPrecioUnitario.Size = new System.Drawing.Size(100, 25);
            this.TxtPrecioUnitario.TabIndex = 9;
            this.TxtPrecioUnitario.TextChanged += new System.EventHandler(this.TxtPrecioUnitario_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio Unitario";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(165, 113);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(601, 25);
            this.TxtDescripcion.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descripcion";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(165, 84);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(601, 25);
            this.TxtNombre.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre del Producto";
            // 
            // DgvFactura
            // 
            this.DgvFactura.AllowUserToAddRows = false;
            this.DgvFactura.AllowUserToDeleteRows = false;
            this.DgvFactura.AllowUserToResizeColumns = false;
            this.DgvFactura.AllowUserToResizeRows = false;
            this.DgvFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcCodigo,
            this.DcNombreProducto,
            this.DcDescripcion,
            this.DcPrecioUnitario});
            this.DgvFactura.Location = new System.Drawing.Point(12, 245);
            this.DgvFactura.Name = "DgvFactura";
            this.DgvFactura.Size = new System.Drawing.Size(754, 203);
            this.DgvFactura.TabIndex = 14;
            // 
            // DcCodigo
            // 
            this.DcCodigo.HeaderText = "CODIGO";
            this.DcCodigo.Name = "DcCodigo";
            this.DcCodigo.Width = 80;
            // 
            // DcNombreProducto
            // 
            this.DcNombreProducto.HeaderText = "NOMBRE DEL PRODUCTO";
            this.DcNombreProducto.Name = "DcNombreProducto";
            this.DcNombreProducto.Width = 300;
            // 
            // DcDescripcion
            // 
            this.DcDescripcion.HeaderText = "DESCRIPCION";
            this.DcDescripcion.Name = "DcDescripcion";
            this.DcDescripcion.Width = 250;
            // 
            // DcPrecioUnitario
            // 
            this.DcPrecioUnitario.HeaderText = "PRECIO UNITARIO";
            this.DcPrecioUnitario.Name = "DcPrecioUnitario";
            this.DcPrecioUnitario.Width = 80;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Aqua;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 40);
            this.label6.TabIndex = 15;
            this.label6.Text = "Datos Registrados";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAgregar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(680, 30);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(86, 48);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnLimpiar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(588, 30);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(86, 48);
            this.BtnLimpiar.TabIndex = 17;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TxtISV
            // 
            this.TxtISV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtISV.Location = new System.Drawing.Point(341, 471);
            this.TxtISV.Name = "TxtISV";
            this.TxtISV.ReadOnly = true;
            this.TxtISV.Size = new System.Drawing.Size(92, 25);
            this.TxtISV.TabIndex = 21;
            this.TxtISV.Text = "0.00";
            this.TxtISV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(307, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "ISV";
            // 
            // TxtTotalaPagar
            // 
            this.TxtTotalaPagar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtTotalaPagar.Location = new System.Drawing.Point(588, 471);
            this.TxtTotalaPagar.Name = "TxtTotalaPagar";
            this.TxtTotalaPagar.ReadOnly = true;
            this.TxtTotalaPagar.Size = new System.Drawing.Size(92, 25);
            this.TxtTotalaPagar.TabIndex = 23;
            this.TxtTotalaPagar.Text = "0.00";
            this.TxtTotalaPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(494, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Total a Pagar";
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtSubTotal.Location = new System.Drawing.Point(126, 470);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.ReadOnly = true;
            this.TxtSubTotal.Size = new System.Drawing.Size(92, 25);
            this.TxtSubTotal.TabIndex = 25;
            this.TxtSubTotal.Text = "0.00";
            this.TxtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "SubTotal";
            // 
            // FormFactura
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(827, 517);
            this.ControlBox = false;
            this.Controls.Add(this.TxtSubTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtTotalaPagar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtISV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DgvFactura);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPrecioUnitario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.DgvFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPrecioUnitario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgvFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcPrecioUnitario;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TextBox TxtISV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTotalaPagar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.Label label7;
    }
}