using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace PSR_VentaEntradas_CopaAmerica
{
    public class ConexionBD
    {
        public string cadena = "Data Source=.\\sqlexpress ; Initial Catalog=VentaEntradasCA;Integrated Security=true;TrustServerCertificate=true";
        public SqlConnection conexion = new SqlConnection();
        public ConexionBD()
        {
            conexion.ConnectionString = cadena;
        }
        public void abrirConexion()
        {
            try
            {
                conexion.Open();
                Debug.WriteLine("Conexion Existosa");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("No se pudo acceder a la BD: "+ex.Message);
            }
        }
    }
}
