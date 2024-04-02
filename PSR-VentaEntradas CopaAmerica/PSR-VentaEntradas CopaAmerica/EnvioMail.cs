using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            else if(!txbCorreo.Text.Trim().Contains("@gmail.com"))
            {
                MessageBox.Show("DIRECCION DE CORREO INVALIDO", "Informacion incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                #region ENVIAR MAIL FUNCIONAL

                MailMessage email = new MailMessage();
                email.To.Add(new MailAddress(txbCorreo.Text.Trim()));
                email.From = new MailAddress("gfulguera@netval.com.ar");
                email.Subject = "PSR - ENTRADAS VENDIDAS";
                email.Body = DateTime.Now.ToString("dd / MMM / yyy hh: mm:ss")+"<br><p><b>Cantidad de entradas vendidas: " +Program.misClientes.Count+"</b></p><br>"+detalleMsjMail();
                email.IsBodyHtml = true;
                email.Priority = MailPriority.Normal;

                SmtpClient smtp = new SmtpClient("smtp.hostinger.com", 587);
                //smtp.Host = "gmail.com";
                //smtp.Port = 465; // verificar el puerto
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("gfulguera@netval.com.ar", "Fulguera@2023");
                string output = null;

                try
                {
                    smtp.Send(email);
                    email.Dispose();
                    output = "Corre electrónico fue enviado satisfactoriamente.";
                }
                catch (Exception ex)
                {
                    output = "Error enviando correo electrónico: " + ex.Message;
                }
                Debug.WriteLine(output);
                #endregion

                //para quitar todos los Labels que creamos 
                foreach (Control item in pnlBodyTable.Controls.OfType<Label>().ToList())
                {
                    pnlBodyTable.Controls.Remove(item);
                }
                //limia la lista temporal para nuevo ingreso
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
        public string detalleMsjMail()
        {
            string detalle="<p>";
            int i = 1;
            foreach(var item in Program.misClientes)
            {
                string mayor = item.MayorDeEdad ? "SI" : "NO";
                detalle += i + ". " + item.Nombre + " " +item.Apellido+" - "+mayor+" - "+item.MedioDePago+" - $"+valorFinal(item.MedioDePago)+"<br>";
                i++;
            }
            detalle += "</p>";
            return detalle;
        }
    }
}
