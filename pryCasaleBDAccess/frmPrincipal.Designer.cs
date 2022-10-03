namespace pryCasaleBDAccess
{
    partial class frmPrincipal
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnAbrirTabla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(12, 12);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(392, 72);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectarme";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformacion.Location = new System.Drawing.Point(12, 299);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(392, 61);
            this.lblInformacion.TabIndex = 1;
            this.lblInformacion.Text = "Info:";
            // 
            // btnAbrirTabla
            // 
            this.btnAbrirTabla.Location = new System.Drawing.Point(12, 90);
            this.btnAbrirTabla.Name = "btnAbrirTabla";
            this.btnAbrirTabla.Size = new System.Drawing.Size(392, 72);
            this.btnAbrirTabla.TabIndex = 2;
            this.btnAbrirTabla.Text = "Abrir Tabla";
            this.btnAbrirTabla.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 369);
            this.Controls.Add(this.btnAbrirTabla);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.btnConectar);
            this.Name = "frmPrincipal";
            this.Text = "Conexión a Base de Datos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Button btnAbrirTabla;
    }
}

