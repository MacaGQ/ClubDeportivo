using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.Field;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
using System.Text;

namespace ClubDeportivo.Datos
{
    internal class Socio
    {
        public string Nuevo_Socio(E_Socio socio)
        {
            string? salida;

            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("RegistrarSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = socio.NombreS;
                comando.Parameters.Add("Apellido", MySqlDbType.VarChar).Value = socio.ApellidoS;
                comando.Parameters.Add("Doc", MySqlDbType.Int32).Value = socio.DocS;

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

        public static bool SocioExiste(int IDSocio)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            bool existe = false;

            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = ("SELECT IDsocio FROM socio WHERE IDsocio =" + IDSocio);

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;

                reader = comando.ExecuteReader();

                existe = reader.HasRows;

                return existe;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AVISO DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        public static int ActividadesRealizadas(int IDsocio)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            int actividades = 0;

            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = ("SELECT cantidadActividades FROM socio WHERE IDsocio =" + IDsocio);

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;

                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    actividades = reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return actividades;
        }

        public static void SumarActividad(int IDsocio)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("sumarActividad", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("IDsoc", MySqlDbType.Int32).Value = IDsocio;

                sqlCon.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }           
        }

    }
        
}
