using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MySQL
{
    class conexion
    {
        public DataTable dt = new DataTable();

        static string strPassword = "5266";
        static string strPort = "3306";

        //static string strPassword = "123456";
        //static string strPort = "8080";
        
        static string strDatabase = "hotel";

        public string strConexion = "Server=localhost;Port=" + strPort + "; Uid = root; Pwd=" + strPassword + "; Database=" + strDatabase + ";";
        public MySqlConnection conectar = new MySqlConnection();

        public bool abrir()
        {
            try
            {
                conectar.ConnectionString = strConexion;
                conectar.Open();
                Console.WriteLine("abierta");
                return true;
            }
            catch
            {
                Console.WriteLine("no abierta");
                return false;
            }
        }

        public bool cerrar()
        {
            try
            {
                conectar.Close();
                Console.WriteLine("cerrada");
                return true;
            }
            catch
            {
                Console.WriteLine("no cerrada");
                return false;
            }

        }

        public System.Data.DataTable cargarDatos(String query)
        {
            dt = new System.Data.DataTable();
            try
            {
                abrir();
                MySqlDataAdapter comando = new MySqlDataAdapter(query, strConexion);
                comando.Fill(dt);
                Console.WriteLine("cargado");
                cerrar();
                return dt;
            }
            catch
            {
                Console.WriteLine("no cargado");
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
                Console.WriteLine("query ejecutada");
                return true;
            }
            catch
            {
                Console.WriteLine("query no ejecutada");
                return false;
            }
        }
    }
}
