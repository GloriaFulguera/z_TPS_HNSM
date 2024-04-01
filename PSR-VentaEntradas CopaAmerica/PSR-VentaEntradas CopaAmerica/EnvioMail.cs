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
                MessageBox.Show("DEBE COMPLETAR TODOS EL CAMPO CORREO ELECTRONICO", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Program.misClientes.Clear();
                lsbDetalleMail.Items.Clear();
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
                string detEntrada = "     " + i.ToString() + ".          " + cli.Nombre + "   " + cli.Apellido + " -    " + mayor + " -    " + cli.MedioDePago + "    -      $ " + valorFinal(cli.MedioDePago);
                lsbDetalleMail.Items.Add(detEntrada);
                i++;
            }
        }
    }
}
