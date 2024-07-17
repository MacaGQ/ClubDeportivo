using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class NoSocio
    {
        public string Nuevo_NoSocio(E_NoSocio noSocio)
        {
            string? salida;

            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("RegistrarNS", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = noSocio.NombreNoS;
                comando.Parameters.Add("Apellido", MySqlDbType.VarChar).Value = noSocio.ApellidoNoS;
                comando.Parameters.Add("Doc", MySqlDbType.Int32).Value = noSocio.DocNoS;

                MySqlParameter ParCodigo = new MySqlParameter();

                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return salida;
        }

    }
}
