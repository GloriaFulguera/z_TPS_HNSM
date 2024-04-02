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

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> oLista= new List<Cliente>();
            try
            {
                ConexionBD cn= new ConexionBD();
                cn.abrirConexion();

                SqlCommand cmd=new SqlCommand("sp_ObtenerClientes",cn.conexion);
                cmd.CommandType=System.Data.CommandType.StoredProcedure;
                using(var dr=cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var nombre = dr["Nombre"].ToString();
                        var apellido = dr["Apellido"].ToString();
                        var mayor = (Convert.ToChar(dr["MayorDeEdad"]) == '1') ? true : false;
                        var medioPago= dr["MedioDePago"].ToString();

                        oLista.Add(new Cliente(nombre,apellido,mayor,medioPago));
                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return oLista;
        }
    }
}
/*
 using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new ContactoModel()
                        {
                            idContacto = Convert.ToInt32(dr["idContacto"]),
                            Nombre = dr["Nombre"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Email = dr["Email"].ToString()
                        });
                    }
                }
 */