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
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            List<Cliente> registroVentas = new List<Cliente>();
            ClienteDatos data= new ClienteDatos();

            registroVentas=data.ObtenerClientes();
            foreach(var cli in registroVentas)
            {
                string reg=cli.Nombre+" "+cli.Apellido+"     -      "+cli.MedioDePago;
                crearRegistro(reg.ToUpper());
            }
        }
        public void crearRegistro(string contenido)
        {
            Label lbl = new Label();
            lbl.Text = contenido;
            lbl.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Padding = new Padding(10, 20, 10, 20);
            //lbl.AutoSize = true;
            lbl.Dock = DockStyle.Top;
            lbl.Size = new Size(740, 65);
            lbl.BorderStyle= BorderStyle.FixedSingle;

            pnlDetOperaciones.Controls.Add(lbl);
        }
    }
}
