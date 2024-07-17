﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion()
        {
            bool correcto = false;
            int mensaje;

            string T_servidor = "Servidor";
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave";

            while (!correcto)
            {
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese servidor", "DATOS DE INSTALACION MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox("Ingrese puerto", "DATOS DE INSTALACION MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese usuario", "DATOS DE INSTALACION MySQL");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox("Ingrese clave", "DATOS DE INSTALACION MySQL");

                mensaje = (int)MessageBox.Show("Su Ingreso: SERVIDOR = " + T_servidor + " PUERTO = " + T_puerto + " USUARIO: " + T_usuario + " CLAVE:" + T_clave, "AVISO DEL SISTEMA",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje != 6)
                {
                    MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }
            }

            this.baseDatos = "ClubDeportivo";
            this.servidor = T_servidor;
            this.puerto = T_puerto;
            this.usuario = T_usuario;
            this.clave = T_clave;
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor + ";port=" + this.puerto + ";username=" + this.usuario + ";password=" + this.clave + ";Database=" + this.baseDatos;

            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }

            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }

            return con;
        }

    }
}
