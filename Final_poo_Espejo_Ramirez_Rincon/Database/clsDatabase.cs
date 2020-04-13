using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Final_poo_Espejo_Ramirez_Rincon.Database
{
    public class clsDatabase
    {

        private static clsDatabase _instance;

        // Atributos para conexion a la base de datos
        private const string HOST = "localhost";
        private const string USER = "postgres";
        private const string PORT = "5432";
        private const string PASSWORD = "juan0617";
        private const string DATABASE = "dbcinemax";

        // Atributo para trabajar con la base de datos
        private NpgsqlConnection conn;

        /// <summary>
        /// String de conexión
        /// </summary>
        private string ConnString { get =>
         $"Server={HOST};Port={PORT};Database={DATABASE};UserId={USER};Password={PASSWORD}";
                }

        public NpgsqlConnection Connection { get => conn; }

        private clsDatabase()
        {
            conn = new NpgsqlConnection(ConnString);
        }

        /// <summary>
        /// Unica instancia de la clase Database
        /// </summary>
        public static clsDatabase Instance {
            get {
                    if(_instance == null)
                    {
                        _instance = new clsDatabase();
                    }

                    return _instance;
                }
        }

        /// <summary>
        /// Hace una consulta fija a la base de datos
        /// </summary>
        /// <param name="sql">SQL a ser ejecutado</param>
        /// 
        //string result;

        /*
        public string query(string sql)
        {
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

            NpgsqlDataReader reader = cmd.ExecuteReader();
            conn.Close();

            return result = reader.ToString();
             
            
            
        }
        */


    }
}
