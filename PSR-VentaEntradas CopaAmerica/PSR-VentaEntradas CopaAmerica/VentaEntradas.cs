using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PSR_VentaEntradas_CopaAmerica
{
    public partial class VentaEntradas : Form
    {
        public VentaEntradas()
        {
            InitializeComponent();
        }
        
        private void VentaEntradas_Load(object sender, EventArgs e)
        {
            ConexionBD cone= new ConexionBD();
            cone.abrirConexion();
        }
    }
}
