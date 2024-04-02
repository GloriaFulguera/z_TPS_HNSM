using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSR_VentaEntradas_CopaAmerica
{
    public partial class EnvioMail : Form
    {
        public EnvioMail()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txbCorreo.Text.Trim() == "")
            {
                MessageBox.Show("DEBE COMPLETAR EL CAMPO CORREO ELECTRONICO", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Program.misClientes.Clear();
                txbCorreo.Text= string.Empty;
                MessageBox.Show("Mensaje enviado con éxito", "Informacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        public double valorFinal(string medPago)
        {
            double valor = 4000;
            switch (medPago)
            {
                case "EFECTIVO":
                    valor -= (valor * 0.50);
                    break;
                case "MERCADO PAGO":
                    valor -= (valor * 0.25);
                    break;
                case "TARJETA DE CREDITO":

                    break;
            }
            return valor;
        }

        private void EnvioMail_Load(object sender, EventArgs e)
        {
            int i = 1;
            foreach (var cli in Program.misClientes)
            {
                
                string mayor = cli.MayorDeEdad ? "SI" : "NO";
                string detVentaUnit = "       " + i.ToString() + ".          " + cli.Nombre + "   " + cli.Apellido + " -    " + mayor + " -    " + cli.MedioDePago + "    -      $ " + valorFinal(cli.MedioDePago);
                crearRegistro(detVentaUnit);
                i++;
            }
        }
        public void crearRegistro(string contenido)
        {
            Label lbl = new Label();
            lbl.Text = contenido;
            lbl.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Padding = new Padding(0, 12, 0, 12);
            //lbl.AutoSize = true;
            lbl.Dock = DockStyle.Top;
            lbl.Size = new Size(721, 45);
            lbl.BorderStyle= BorderStyle.FixedSingle;

            pnlBodyTable.Controls.Add(lbl);
        }
    }
}
