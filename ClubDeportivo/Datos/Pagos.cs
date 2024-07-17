using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class Pagos
    {
        public static void CrearFactura(int IDsocio)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("CrearFactura", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("IDsoc", MySqlDbType.Int32).Value = IDsocio;
                
                sqlCon.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) {
                    sqlCon.Close();
                }
            }

        }

        public static void PagarCuota(int IDsocio)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("PagarCuota", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("IDsoc", MySqlDbType.Int32).Value = IDsocio;

                sqlCon.Open();
                comando.ExecuteNonQuery();

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
        }
    }
}
