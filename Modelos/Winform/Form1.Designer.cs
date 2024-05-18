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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelEspacioDisponible = new System.Windows.Forms.Label();
            this.labelTamañoBuzon = new System.Windows.Forms.Label();
            this.botonEnviar = new System.Windows.Forms.Button();
            this.labelNuevoMensaje = new System.Windows.Forms.Label();
            this.textBoxMensaje = new System.Windows.Forms.TextBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.labelPesoAdjunto = new System.Windows.Forms.Label();
            this.labelDestinatario = new System.Windows.Forms.Label();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.textBoxDestinatario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(8, 6);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(321, 46);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Casilla de correo";
            // 
            // labelEspacioDisponible
            // 
            this.labelEspacioDisponible.AutoSize = true;
            this.labelEspacioDisponible.Location = new System.Drawing.Point(16, 65);
            this.labelEspacioDisponible.Name = "labelEspacioDisponible";
            this.labelEspacioDisponible.Size = new System.Drawing.Size(98, 13);
            this.labelEspacioDisponible.TabIndex = 3;
            this.labelEspacioDisponible.Text = "Espacio disponible:";
            // 
            // labelTamañoBuzon
            // 
            this.labelTamañoBuzon.AutoSize = true;
            this.labelTamañoBuzon.Location = new System.Drawing.Point(15, 52);
            this.labelTamañoBuzon.Name = "labelTamañoBuzon";
            this.labelTamañoBuzon.Size = new System.Drawing.Size(96, 13);
            this.labelTamañoBuzon.TabIndex = 4;
            this.labelTamañoBuzon.Text = "Tamaño de buzon:";
            // 
            // botonEnviar
            // 
            this.botonEnviar.Location = new System.Drawing.Point(275, 208);
            this.botonEnviar.Name = "botonEnviar";
            this.botonEnviar.Size = new System.Drawing.Size(75, 23);
            this.botonEnviar.TabIndex = 5;
            this.botonEnviar.Text = "Enviar";
            this.botonEnviar.UseVisualStyleBackColor = true;
            this.botonEnviar.Click += new System.EventHandler(this.botonEnviar_Click);
            // 
            // labelNuevoMensaje
            // 
            this.labelNuevoMensaje.AutoSize = true;
            this.labelNuevoMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevoMensaje.Location = new System.Drawing.Point(13, 100);
            this.labelNuevoMensaje.Name = "labelNuevoMensaje";
            this.labelNuevoMensaje.Size = new System.Drawing.Size(106, 17);
            this.labelNuevoMensaje.TabIndex = 6;
            this.labelNuevoMensaje.Text = "Nuevo Mensaje";
            // 
            // textBoxMensaje
            // 
            this.textBoxMensaje.Location = new System.Drawing.Point(84, 152);
            this.textBoxMensaje.Name = "textBoxMensaje";
            this.textBoxMensaje.Size = new System.Drawing.Size(266, 20);
            this.textBoxMensaje.TabIndex = 7;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(84, 178);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(65, 20);
            this.textBoxPeso.TabIndex = 8;
            // 
            // labelPesoAdjunto
            // 
            this.labelPesoAdjunto.AutoSize = true;
            this.labelPesoAdjunto.Location = new System.Drawing.Point(12, 181);
            this.labelPesoAdjunto.Name = "labelPesoAdjunto";
            this.labelPesoAdjunto.Size = new System.Drawing.Size(34, 13);
            this.labelPesoAdjunto.TabIndex = 9;
            this.labelPesoAdjunto.Text = "Peso:";
            // 
            // labelDestinatario
            // 
            this.labelDestinatario.AutoSize = true;
            this.labelDestinatario.Location = new System.Drawing.Point(12, 129);
            this.labelDestinatario.Name = "labelDestinatario";
            this.labelDestinatario.Size = new System.Drawing.Size(66, 13);
            this.labelDestinatario.TabIndex = 10;
            this.labelDestinatario.Text = "Destinatario:";
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Location = new System.Drawing.Point(12, 155);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(50, 13);
            this.labelMensaje.TabIndex = 11;
            this.labelMensaje.Text = "Mensaje:";
            // 
            // textBoxDestinatario
            // 
            this.textBoxDestinatario.Location = new System.Drawing.Point(84, 126);
            this.textBoxDestinatario.Name = "textBoxDestinatario";
            this.textBoxDestinatario.Size = new System.Drawing.Size(84, 20);
            this.textBoxDestinatario.TabIndex = 12;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 247);
            this.Controls.Add(this.textBoxDestinatario);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.labelDestinatario);
            this.Controls.Add(this.labelPesoAdjunto);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxMensaje);
            this.Controls.Add(this.labelNuevoMensaje);
            this.Controls.Add(this.botonEnviar);
            this.Controls.Add(this.labelTamañoBuzon);
            this.Controls.Add(this.labelEspacioDisponible);
            this.Controls.Add(this.labelTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ouluk";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelEspacioDisponible;
        private System.Windows.Forms.Label labelTamañoBuzon;
        private System.Windows.Forms.Button botonEnviar;
        private System.Windows.Forms.Label labelNuevoMensaje;
        private System.Windows.Forms.TextBox textBoxMensaje;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Label labelPesoAdjunto;
        private System.Windows.Forms.Label labelDestinatario;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.TextBox textBoxDestinatario;
    }
}

