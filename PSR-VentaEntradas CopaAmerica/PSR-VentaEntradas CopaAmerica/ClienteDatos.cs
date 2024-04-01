using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSR_VentaEntradas_CopaAmerica
{
    public class ClienteDatos
    {
        public bool Guardar(Cliente oCliente)
        {
            bool rta;
            
            try
            {
                ConexionBD cn = new ConexionBD();
                cn.abrirConexion();
                Debug.WriteLine(cn.conexion.State);

                SqlCommand cmd = new SqlCommand("sp_InsertarCliente", cn.conexion);
                cmd.Parameters.AddWithValue("Nombre", oCliente.Nombre);
                cmd.Parameters.AddWithValue("Apellido", oCliente.Apellido);
                if (oCliente.MayorDeEdad)
                    cmd.Parameters.AddWithValue("MayorDeEdad", '1');
                else
                    cmd.Parameters.AddWithValue("MayorDeEdad", '0');
                cmd.Parameters.AddWithValue("MedioDePago", oCliente.MedioDePago);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                rta = true;
                cn.conexion.Close();
                Debug.WriteLine(cn.conexion.State);
            }
            catch (Exception ex)
            {
                rta = false;
            }

            return rta;
        }
    }
}
/*
 conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_Guardar", conexion);
                    cmd.Parameters.AddWithValue("Nombre", oContacto.Nombre);
                    cmd.Parameters.AddWithValue("Telefono", oContacto.Telefono);
                    cmd.Parameters.AddWithValue("Email", oContacto.Email);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
 */