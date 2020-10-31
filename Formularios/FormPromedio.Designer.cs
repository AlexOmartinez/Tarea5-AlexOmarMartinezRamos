namespace Tarea5_AlexOmarMartinez.Formularios
{
    partial class FormPromedio
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
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.DgvPromedio = new System.Windows.Forms.DataGridView();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPromedioGeneral = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNota2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCantAprobados = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNota3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCantReprobados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNota1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtNota4 = new System.Windows.Forms.TextBox();
            this.DcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcNota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcNota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcNota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcNota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPromedio)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(485, 182);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(84, 41);
            this.BtnLimpiar.TabIndex = 37;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(575, 182);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(84, 41);
            this.BtnAgregar.TabIndex = 36;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Aqua;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-1, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 36);
            this.label9.TabIndex = 35;
            this.label9.Text = "Datos Registrados";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvPromedio
            // 
            this.DgvPromedio.AllowUserToAddRows = false;
            this.DgvPromedio.AllowUserToDeleteRows = false;
            this.DgvPromedio.AllowUserToResizeColumns = false;
            this.DgvPromedio.AllowUserToResizeRows = false;
            this.DgvPromedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPromedio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcNombre,
            this.DcNota1,
            this.DcNota2,
            this.DcNota3,
            this.DcNota4});
            this.DgvPromedio.Location = new System.Drawing.Point(17, 259);
            this.DgvPromedio.Name = "DgvPromedio";
            this.DgvPromedio.Size = new System.Drawing.Size(664, 209);
            this.DgvPromedio.TabIndex = 34;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(158, 52);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(504, 25);
            this.TxtNombre.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Nombre del Estudiante";
            // 
            // TxtPromedioGeneral
            // 
            this.TxtPromedioGeneral.Location = new System.Drawing.Point(140, 473);
            this.TxtPromedioGeneral.Name = "TxtPromedioGeneral";
            this.TxtPromedioGeneral.Size = new System.Drawing.Size(100, 25);
            this.TxtPromedioGeneral.TabIndex = 31;
            this.TxtPromedioGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Promedio General";
            // 
            // TxtNota2
            // 
            this.TxtNota2.Location = new System.Drawing.Point(158, 113);
            this.TxtNota2.Name = "TxtNota2";
            this.TxtNota2.Size = new System.Drawing.Size(100, 25);
            this.TxtNota2.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nota 2";
            // 
            // TxtCantAprobados
            // 
            this.TxtCantAprobados.Location = new System.Drawing.Point(387, 476);
            this.TxtCantAprobados.Name = "TxtCantAprobados";
            this.TxtCantAprobados.Size = new System.Drawing.Size(100, 25);
            this.TxtCantAprobados.TabIndex = 27;
            this.TxtCantAprobados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nota 3";
            // 
            // TxtNota3
            // 
            this.TxtNota3.Location = new System.Drawing.Point(158, 144);
            this.TxtNota3.Name = "TxtNota3";
            this.TxtNota3.Size = new System.Drawing.Size(100, 25);
            this.TxtNota3.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cantidad Reprobados";
            // 
            // TxtCantReprobados
            // 
            this.TxtCantReprobados.Location = new System.Drawing.Point(655, 476);
            this.TxtCantReprobados.Name = "TxtCantReprobados";
            this.TxtCantReprobados.Size = new System.Drawing.Size(100, 25);
            this.TxtCantReprobados.TabIndex = 23;
            this.TxtCantReprobados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cantidad Aprobados";
            // 
            // TxtNota1
            // 
            this.TxtNota1.Location = new System.Drawing.Point(158, 83);
            this.TxtNota1.Name = "TxtNota1";
            this.TxtNota1.Size = new System.Drawing.Size(100, 25);
            this.TxtNota1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nota 1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ingrese los Datos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(105, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Nota 4";
            // 
            // TxtNota4
            // 
            this.TxtNota4.Location = new System.Drawing.Point(158, 175);
            this.TxtNota4.Name = "TxtNota4";
            this.TxtNota4.Size = new System.Drawing.Size(100, 25);
            this.TxtNota4.TabIndex = 38;
            // 
            // DcNombre
            // 
            this.DcNombre.HeaderText = "NOMBRE DEL ESTUDIANTE";
            this.DcNombre.Name = "DcNombre";
            this.DcNombre.Width = 300;
            // 
            // DcNota1
            // 
            this.DcNota1.HeaderText = "NOTA 1";
            this.DcNota1.Name = "DcNota1";
            this.DcNota1.Width = 80;
            // 
            // DcNota2
            // 
            this.DcNota2.HeaderText = "NOTA 2";
            this.DcNota2.Name = "DcNota2";
            this.DcNota2.Width = 80;
            // 
            // DcNota3
            // 
            this.DcNota3.HeaderText = "NOTA 3";
            this.DcNota3.Name = "DcNota3";
            this.DcNota3.Width = 80;
            // 
            // DcNota4
            // 
            this.DcNota4.HeaderText = "NOTA 4";
            this.DcNota4.Name = "DcNota4";
            this.DcNota4.Width = 80;
            // 
            // FormPromedio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(770, 513);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtNota4);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DgvPromedio);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtPromedioGeneral);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtNota2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCantAprobados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNota3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCantReprobados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNota1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPromedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Promedio Notas de un Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPromedio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DgvPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNota4;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPromedioGeneral;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNota2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCantAprobados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNota3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCantReprobados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNota1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtNota4;
    }
}