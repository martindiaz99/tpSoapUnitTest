namespace Winform
{
    partial class FormPrincipal
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
            this.BotonConsultarEspacioTotal = new System.Windows.Forms.Button();
            this.botonCalcularEspacioDisponible = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonConsultarEspacioTotal
            // 
            this.BotonConsultarEspacioTotal.Location = new System.Drawing.Point(130, 81);
            this.BotonConsultarEspacioTotal.Name = "BotonConsultarEspacioTotal";
            this.BotonConsultarEspacioTotal.Size = new System.Drawing.Size(118, 76);
            this.BotonConsultarEspacioTotal.TabIndex = 0;
            this.BotonConsultarEspacioTotal.Text = "Calcular espacio total";
            this.BotonConsultarEspacioTotal.UseVisualStyleBackColor = true;
            this.BotonConsultarEspacioTotal.Click += new System.EventHandler(this.BotonConsultarEspacioTotal_Click);
            // 
            // botonCalcularEspacioDisponible
            // 
            this.botonCalcularEspacioDisponible.Location = new System.Drawing.Point(254, 81);
            this.botonCalcularEspacioDisponible.Name = "botonCalcularEspacioDisponible";
            this.botonCalcularEspacioDisponible.Size = new System.Drawing.Size(118, 76);
            this.botonCalcularEspacioDisponible.TabIndex = 1;
            this.botonCalcularEspacioDisponible.Text = "Calcular espacio disponible";
            this.botonCalcularEspacioDisponible.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(478, 69);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Casilla de correo";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 191);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.botonCalcularEspacioDisponible);
            this.Controls.Add(this.BotonConsultarEspacioTotal);
            this.Name = "FormPrincipal";
            this.Text = "Outlook?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonConsultarEspacioTotal;
        private System.Windows.Forms.Button botonCalcularEspacioDisponible;
        private System.Windows.Forms.Label labelTitulo;
    }
}

