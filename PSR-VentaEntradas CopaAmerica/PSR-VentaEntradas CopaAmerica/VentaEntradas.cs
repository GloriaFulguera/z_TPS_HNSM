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
            ConexionBD cone = new ConexionBD();
            cone.abrirConexion();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txbNombre.Text.Trim() == "" || txbApellido.Text.Trim() == "" || lblMedioSeleccionado.Text == "NINGUNO")
            {
                MessageBox.Show("DEBE COMPLETAR TODOS LOS CAMPOS Y SELECCIONAR UN MEDIO DE PAGO", "Faltan datos",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente cli = new Cliente(txbNombre.Text, txbApellido.Text, ckbMayorEdad.Checked, lblMedioSeleccionado.Text);
                    Debug.WriteLine("MAYOR DE EDAD: " + cli.MayorDeEdad);
                    ClienteDatos dbCli = new ClienteDatos();
                    /*bool result=dbCli.Guardar(cli);
                    if (result)
                    {*/
                        MessageBox.Show("Cliente guardado con éxito", "Informacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.None);
                        Program.misClientes.Add(cli);
                    //}
                    limiarFormulario();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        public void limiarFormulario()
        {
            txbNombre.Clear();
            txbApellido.Clear();
            ckbMayorEdad.Checked = false;
            lblMedioSeleccionado.Text = "NINGUNO";
        }
        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            lblMedioSeleccionado.Text = "EFECTIVO";
        }

        private void btnMercadoPago_Click(object sender, EventArgs e)
        {
            lblMedioSeleccionado.Text = "MERCADO PAGO";
        }

        private void btnTarjetaCredito_Click(object sender, EventArgs e)
        {
            lblMedioSeleccionado.Text = "TARJETA DE CREDITO";
        }
    }
}
