using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace MasterPage1
{
    class conexion
    {
        

        //static string strPassword = "5266";
        //static string strPort = "3306";

        static string strPassword = "123456";
        static string strPort = "3306";
        
        static string strDatabase = "carrito";

        public string strConexion = "Server=localhost;Port=" + strPort + "; Uid = root; Pwd=" + strPassword + "; Database=" + strDatabase + ";";
        public MySqlConnection conectar = new MySqlConnection();

        public bool abrir()
        {
            try
            {
                conectar.ConnectionString = strConexion;
                conectar.Open();
                System.Diagnostics.Debug.WriteLine("abierta");
                return true;
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("no abierta");
                return false;
            }
        }

        public bool cerrar()
        {
            try
            {
                conectar.Close();
                System.Diagnostics.Debug.WriteLine("cerrada");
                return true;
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("no cerrada");
                return false;
            }

        }

        public DataTable cargarDatos(String query)
        {
            DataTable dt = new DataTable();
            try
            {
                abrir();
                MySqlDataAdapter comando = new MySqlDataAdapter(query, strConexion);
                comando.Fill(dt);
                System.Diagnostics.Debug.WriteLine("cargados "+dt.);
                cerrar();
                return dt;
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("no cargado");
                return null;
            }
        }

        public bool ejecutarquery(string query)
        {
            try
            {
                abrir();
                MySqlCommand comando = new MySqlCommand(query, conectar);
                comando.ExecuteNonQuery();
                cerrar();
                System.Diagnostics.Debug.WriteLine("query ejecutada");
                return true;
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("query no ejecutada");
                return false;
            }
        }
    }
}
