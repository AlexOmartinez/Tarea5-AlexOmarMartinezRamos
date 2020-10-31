namespace Tarea5_AlexOmarMartinez.Formularios
{
    partial class FormNota_para_Aprovar
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
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TxtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNotaSE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNotaPE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNotaTE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNotaNA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSalir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(367, 230);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(66, 34);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnLimpiar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(295, 230);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(66, 34);
            this.BtnLimpiar.TabIndex = 3;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TxtNombreEstudiante
            // 
            this.TxtNombreEstudiante.Location = new System.Drawing.Point(175, 48);
            this.TxtNombreEstudiante.Name = "TxtNombreEstudiante";
            this.TxtNombreEstudiante.Size = new System.Drawing.Size(236, 25);
            this.TxtNombreEstudiante.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre del Estudiante";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese los Datos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNotaSE
            // 
            this.TxtNotaSE.Location = new System.Drawing.Point(175, 105);
            this.TxtNotaSE.Name = "TxtNotaSE";
            this.TxtNotaSE.Size = new System.Drawing.Size(100, 25);
            this.TxtNotaSE.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nota del Segundo Examen";
            // 
            // TxtNotaPE
            // 
            this.TxtNotaPE.Location = new System.Drawing.Point(175, 77);
            this.TxtNotaPE.Name = "TxtNotaPE";
            this.TxtNotaPE.Size = new System.Drawing.Size(100, 25);
            this.TxtNotaPE.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nota del Primer Examen";
            // 
            // TxtNotaTE
            // 
            this.TxtNotaTE.Location = new System.Drawing.Point(175, 134);
            this.TxtNotaTE.Name = "TxtNotaTE";
            this.TxtNotaTE.Size = new System.Drawing.Size(100, 25);
            this.TxtNotaTE.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nota del Tercer Examen";
            // 
            // TxtNotaNA
            // 
            this.TxtNotaNA.Location = new System.Drawing.Point(207, 199);
            this.TxtNotaNA.Name = "TxtNotaNA";
            this.TxtNotaNA.Size = new System.Drawing.Size(100, 25);
            this.TxtNotaNA.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nota del Necesaria para Aprobar";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCalcular.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(63, 162);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(84, 39);
            this.BtnCalcular.TabIndex = 16;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Aqua;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(133, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "El Valor de Cada Examen es de 20 Puntos";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNota_para_Aprovar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(438, 272);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtNotaNA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtNotaTE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNotaPE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNotaSE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombreEstudiante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnSalir);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormNota_para_Aprovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Nota Necesaria para Aprobar la Clase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TextBox TxtNombreEstudiante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNotaSE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNotaPE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNotaTE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNotaNA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label7;
    }
}