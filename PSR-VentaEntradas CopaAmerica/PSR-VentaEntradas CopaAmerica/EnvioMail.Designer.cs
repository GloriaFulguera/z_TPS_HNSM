namespace PSR_VentaEntradas_CopaAmerica
{
    partial class EnvioMail
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblMedioPago = new System.Windows.Forms.Label();
            this.txbCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDetEnvio = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(63, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(300, 0, 300, 0);
            this.lblTitulo.Size = new System.Drawing.Size(706, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ENVIO DE MAILS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(118)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(884, 50);
            this.pnlTitulo.TabIndex = 1;
            // 
            // lblMedioPago
            // 
            this.lblMedioPago.AutoSize = true;
            this.lblMedioPago.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMedioPago.Location = new System.Drawing.Point(12, 93);
            this.lblMedioPago.Name = "lblMedioPago";
            this.lblMedioPago.Size = new System.Drawing.Size(117, 25);
            this.lblMedioPago.TabIndex = 11;
            this.lblMedioPago.Text = "DATOS DE ENVIO";
            // 
            // txbCorreo
            // 
            this.txbCorreo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCorreo.Location = new System.Drawing.Point(204, 141);
            this.txbCorreo.Name = "txbCorreo";
            this.txbCorreo.Size = new System.Drawing.Size(418, 27);
            this.txbCorreo.TabIndex = 13;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCorreo.Location = new System.Drawing.Point(76, 144);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(122, 19);
            this.lblCorreo.TabIndex = 12;
            this.lblCorreo.Text = "CORREO ELECTRÓNICO";
            // 
            // lblDetEnvio
            // 
            this.lblDetEnvio.AutoSize = true;
            this.lblDetEnvio.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetEnvio.Location = new System.Drawing.Point(12, 228);
            this.lblDetEnvio.Name = "lblDetEnvio";
            this.lblDetEnvio.Size = new System.Drawing.Size(131, 25);
            this.lblDetEnvio.TabIndex = 14;
            this.lblDetEnvio.Text = "DETALLE DE ENVIO";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(118)))));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(192)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(330, 650);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(200, 50);
            this.btnEnviar.TabIndex = 15;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // EnvioMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(884, 761);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblDetEnvio);
            this.Controls.Add(this.txbCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblMedioPago);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnvioMail";
            this.Text = "EnvioMail";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private Panel pnlTitulo;
        private Label lblMedioPago;
        private TextBox txbCorreo;
        private Label lblCorreo;
        private Label lblDetEnvio;
        private Button btnEnviar;
    }
}