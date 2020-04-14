using System;
using Final_poo_Espejo_Ramirez_Rincon.Controllers;
using System.Windows.Forms;
using Npgsql;

namespace Final_poo_Espejo_Ramirez_Rincon.Controllers
{
    

    public class clsUser : clsModel
    {
        // Declaramos variables 
        public static string sql;//para queries
        public static NpgsqlCommand cmd;// declarada para mandar queries y conexion entre programa y base de datos

        public static NpgsqlConnection cone = Database.clsDatabase.Instance.Connection; //hacemos referencia a conexion

        public static bool tryemail(string email)
        {
            // validamos  con el try el correo si existe o no 
           
          
            try
            {
                //se abre el programa con la base de datos
                cone.Open();
                //mandamos el query para la base de datos
                sql = $@"select count(*) from tblUser where email = '{email}'";
                //mandamos el query mas la conexion
                cmd = new NpgsqlCommand(sql, cone);
                //guardamos el resultado generado por la base de datos  
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                //se cierra la conexion entre el programa y la base de datos
                cone.Close();
                if (result == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception er)
            {
                //si hay algun errror se mostrara un mensaje y dira por que
                MessageBox.Show(" " + er);

                return false;
            }


        }

        public static bool tryregistro(string name, string surname, string dni,
            string email, string password)
        {
           // se abre la conexion entre el programa y la base de datos
            cone.Open();
            // realizamos el query entre programa y la base de datos
            sql = $@"insert into tblUser values('{dni}','{email}','{name}','{surname}','{password}',2)";
            //mandamos el query y la conexion
            cmd = new NpgsqlCommand(sql, cone);
            //guardamos el resultado del query
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            // se hace la encriptacion de todas las contraseñas en la base de datos
            sql = $@"update tblUser set password = md5(MD5(password)) ";
            //mandamos la actualizacion mas el conexion
            cmd = new NpgsqlCommand(sql,cone);
            // cerramos la conexion entre el programa y la base de datos
            cone.Close();
            if (result == 0)
            {
                
                return true;
            }
            else
            {
               return false;
            }

        }
    }
}
