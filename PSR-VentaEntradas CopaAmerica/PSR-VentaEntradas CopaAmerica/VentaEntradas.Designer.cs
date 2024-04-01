namespace PSR_VentaEntradas_CopaAmerica
{
    partial class VentaEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaEntradas));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.ckbMayorEdad = new System.Windows.Forms.CheckBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMedioPago = new System.Windows.Forms.Label();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.btnMercadoPago = new System.Windows.Forms.Button();
            this.btnTarjetaCredito = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblSel = new System.Windows.Forms.Label();
            this.lblMedioSeleccionado = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.grbDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(118)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(884, 50);
            this.pnlTitulo.TabIndex = 0;
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
            this.lblTitulo.Size = new System.Drawing.Size(733, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "VENTA DE ENTRADAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbDatosPersonales
            // 
            this.grbDatosPersonales.Controls.Add(this.ckbMayorEdad);
            this.grbDatosPersonales.Controls.Add(this.txbApellido);
            this.grbDatosPersonales.Controls.Add(this.txbNombre);
            this.grbDatosPersonales.Controls.Add(this.lblApellido);
            this.grbDatosPersonales.Controls.Add(this.lblNombre);
            this.grbDatosPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbDatosPersonales.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbDatosPersonales.Location = new System.Drawing.Point(12, 93);
            this.grbDatosPersonales.Name = "grbDatosPersonales";
            this.grbDatosPersonales.Size = new System.Drawing.Size(844, 202);
            this.grbDatosPersonales.TabIndex = 3;
            this.grbDatosPersonales.TabStop = false;
            this.grbDatosPersonales.Text = "DATOS PERSONALES";
            // 
            // ckbMayorEdad
            // 
            this.ckbMayorEdad.AutoSize = true;
            this.ckbMayorEdad.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbMayorEdad.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbMayorEdad.Location = new System.Drawing.Point(21, 155);
            this.ckbMayorEdad.Name = "ckbMayorEdad";
            this.ckbMayorEdad.Size = new System.Drawing.Size(137, 23);
            this.ckbMayorEdad.TabIndex = 9;
            this.ckbMayorEdad.Text = "¿ES MAYOR DE EDAD?";
            this.ckbMayorEdad.UseVisualStyleBackColor = true;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(102, 93);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(301, 30);
            this.txbApellido.TabIndex = 8;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(102, 43);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(301, 30);
            this.txbNombre.TabIndex = 7;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(21, 99);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 19);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "APELLIDO/S";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(21, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 19);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "NOMBRE/S";
            // 
            // lblMedioPago
            // 
            this.lblMedioPago.AutoSize = true;
            this.lblMedioPago.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMedioPago.Location = new System.Drawing.Point(12, 324);
            this.lblMedioPago.Name = "lblMedioPago";
            this.lblMedioPago.Size = new System.Drawing.Size(125, 25);
            this.lblMedioPago.TabIndex = 10;
            this.lblMedioPago.Text = "METODO DE PAGO";
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEfectivo.FlatAppearance.BorderSize = 0;
            this.btnEfectivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.btnEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEfectivo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEfectivo.Image = ((System.Drawing.Image)(resources.GetObject("btnEfectivo.Image")));
            this.btnEfectivo.Location = new System.Drawing.Point(72, 389);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(200, 200);
            this.btnEfectivo.TabIndex = 11;
            this.btnEfectivo.Text = "EFECTIVO";
            this.btnEfectivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnMercadoPago
            // 
            this.btnMercadoPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMercadoPago.FlatAppearance.BorderSize = 0;
            this.btnMercadoPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.btnMercadoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMercadoPago.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMercadoPago.Image = ((System.Drawing.Image)(resources.GetObject("btnMercadoPago.Image")));
            this.btnMercadoPago.Location = new System.Drawing.Point(294, 389);
            this.btnMercadoPago.Name = "btnMercadoPago";
            this.btnMercadoPago.Size = new System.Drawing.Size(300, 200);
            this.btnMercadoPago.TabIndex = 12;
            this.btnMercadoPago.Text = "MERCADO PAGO";
            this.btnMercadoPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMercadoPago.UseVisualStyleBackColor = true;
            // 
            // btnTarjetaCredito
            // 
            this.btnTarjetaCredito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTarjetaCredito.FlatAppearance.BorderSize = 0;
            this.btnTarjetaCredito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.btnTarjetaCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarjetaCredito.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTarjetaCredito.Image = ((System.Drawing.Image)(resources.GetObject("btnTarjetaCredito.Image")));
            this.btnTarjetaCredito.Location = new System.Drawing.Point(617, 389);
            this.btnTarjetaCredito.Name = "btnTarjetaCredito";
            this.btnTarjetaCredito.Size = new System.Drawing.Size(200, 200);
            this.btnTarjetaCredito.TabIndex = 13;
            this.btnTarjetaCredito.Text = "TARJETA DE CRÉDITO";
            this.btnTarjetaCredito.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(118)))));
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(86)))), ((int)(((byte)(192)))));
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.Location = new System.Drawing.Point(330, 650);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(200, 50);
            this.btnGrabar.TabIndex = 14;
            this.btnGrabar.Text = "GRABAR";
            this.btnGrabar.UseVisualStyleBackColor = false;
            // 
            // lblSel
            // 
            this.lblSel.AutoSize = true;
            this.lblSel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSel.Location = new System.Drawing.Point(468, 330);
            this.lblSel.Name = "lblSel";
            this.lblSel.Size = new System.Drawing.Size(85, 19);
            this.lblSel.TabIndex = 10;
            this.lblSel.Text = "Seleccionado: ";
            // 
            // lblMedioSeleccionado
            // 
            this.lblMedioSeleccionado.AutoSize = true;
            this.lblMedioSeleccionado.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMedioSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.lblMedioSeleccionado.Location = new System.Drawing.Point(559, 330);
            this.lblMedioSeleccionado.Name = "lblMedioSeleccionado";
            this.lblMedioSeleccionado.Size = new System.Drawing.Size(54, 19);
            this.lblMedioSeleccionado.TabIndex = 15;
            this.lblMedioSeleccionado.Text = "NINGUNO";
            // 
            // VentaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(884, 761);
            this.Controls.Add(this.lblMedioSeleccionado);
            this.Controls.Add(this.lblSel);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnTarjetaCredito);
            this.Controls.Add(this.btnMercadoPago);
            this.Controls.Add(this.btnEfectivo);
            this.Controls.Add(this.lblMedioPago);
            this.Controls.Add(this.grbDatosPersonales);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentaEntradas";
            this.Text = "VentaEntradas";
            this.Load += new System.EventHandler(this.VentaEntradas_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.grbDatosPersonales.ResumeLayout(false);
            this.grbDatosPersonales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private GroupBox grbDatosPersonales;
        private Label lblApellido;
        private Label lblNombre;
        private CheckBox ckbMayorEdad;
        private TextBox txbApellido;
        private TextBox txbNombre;
        private Label lblMedioPago;
        private Button btnEfectivo;
        private Button btnMercadoPago;
        private Button btnTarjetaCredito;
        private Button btnGrabar;
        private Label lblSel;
        private Label lblMedioSeleccionado;
    }
}