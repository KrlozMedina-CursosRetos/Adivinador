namespace Adivinador
{
    partial class Presentacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GrpPregunta = new System.Windows.Forms.GroupBox();
            this.LblPregunta = new System.Windows.Forms.Label();
            this.BtnSi = new System.Windows.Forms.Button();
            this.BtnNo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.GrpPregunta.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpPregunta
            // 
            this.GrpPregunta.Controls.Add(this.BtnNo);
            this.GrpPregunta.Controls.Add(this.BtnSi);
            this.GrpPregunta.Controls.Add(this.LblPregunta);
            this.GrpPregunta.Location = new System.Drawing.Point(63, 58);
            this.GrpPregunta.Name = "GrpPregunta";
            this.GrpPregunta.Size = new System.Drawing.Size(502, 180);
            this.GrpPregunta.TabIndex = 0;
            this.GrpPregunta.TabStop = false;
            this.GrpPregunta.Text = "Pregunta";
            // 
            // LblPregunta
            // 
            this.LblPregunta.Location = new System.Drawing.Point(18, 25);
            this.LblPregunta.Name = "LblPregunta";
            this.LblPregunta.Size = new System.Drawing.Size(457, 68);
            this.LblPregunta.TabIndex = 0;
            // 
            // BtnSi
            // 
            this.BtnSi.Location = new System.Drawing.Point(123, 122);
            this.BtnSi.Name = "BtnSi";
            this.BtnSi.Size = new System.Drawing.Size(75, 23);
            this.BtnSi.TabIndex = 1;
            this.BtnSi.Text = "Si";
            this.BtnSi.UseVisualStyleBackColor = true;
            // 
            // BtnNo
            // 
            this.BtnNo.Location = new System.Drawing.Point(326, 122);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(75, 23);
            this.BtnNo.TabIndex = 2;
            this.BtnNo.Text = "No";
            this.BtnNo.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(490, 257);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 305);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.GrpPregunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Presentacion";
            this.Text = "Presentacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpPregunta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpPregunta;
        private System.Windows.Forms.Button BtnNo;
        private System.Windows.Forms.Button BtnSi;
        private System.Windows.Forms.Label LblPregunta;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

