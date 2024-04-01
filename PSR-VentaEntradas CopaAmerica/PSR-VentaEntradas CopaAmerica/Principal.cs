using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSR_VentaEntradas_CopaAmerica
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnVenderEntrada_Click(object sender, EventArgs e)
        {
            openChildForm(new VentaEntradas());
            
        }

        private void btnEnviarMail_Click(object sender, EventArgs e)
        {
            openChildForm(new EnvioMail());
        }

        private void btnHistorialVentas_Click(object sender, EventArgs e)
        {

        }
        private Form activo = null;
        private void openChildForm(Form childForm)
        {
            if(activo != null)
            {
                activo.Close();
            }
            activo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            pnlPantallas.Controls.Add(childForm);
            pnlPantallas.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
