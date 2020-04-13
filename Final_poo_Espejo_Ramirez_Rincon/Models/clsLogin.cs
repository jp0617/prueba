using System;
using System.Windows.Forms;
using Npgsql;
using Final_poo_Espejo_Ramirez_Rincon.Views;

namespace Final_poo_Espejo_Ramirez_Rincon.Models
{
    public class clsLogin : clsModel
      //hacemos la herencia desde la clase clsmodel
    {
        
        // Hacemos la referncia a la clase clsDatabase en la cual se encuentra
        //la conexión a la base de datos

        public bool TryUser(string correo)
            // esta función nos retorna un falso o verdadero
        { 
            
            /* Dentro del try validamos que el usuario exista y 
             * si existe nos retorna verdadero
             * y nos mostrara el boton buy (comprar)
             * y si es falso nos mostrara un mensaje que el usuario no existe
             */
            try
            { 
                //se abre la conexion entre el programa y la base de datos
                Db.Connection.Open();
                //query hacia la base de datos
                string sql = $@"select count(*) from tblUser where email ='{correo}'";
                //mandamos el query y la conexión
                NpgsqlCommand cmd = new NpgsqlCommand(sql, Db.Connection);
                // el resultado del query sera guardado como una nueva variable
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                //se cierra la conexion entre el programa y la base de datos.
                Db.Connection.Close();
                if (result == 1)
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
              //Si hay un error en la consulta  nos devolvera un mensaje con el error
                MessageBox.Show(" " + er);

                return false;
            }
        }


        //Funcion para iniciar seccion 
        public static void TryLogin(string user, string password,TextBox id)
        {
             
            
            try
            {
                cone.Open(); //Abrir la conexion entre el programa y la base de datos 
                // query para ingresar
                string sql = $@"select rol from tblUser where email='{user}' and password='{password}'"; 
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cone); //Validar conexion y la funcion del query
                NpgsqlDataReader dr = cmd.ExecuteReader();//Guarda el valor retornado
                //Cierre de la conexion entre el programa y la base de datos
                while (dr.Read())
                {
                   id.Text = dr["rol"].ToString();
                    
                }
                cone.Close();
                

            }
            catch (Exception er)
            {
                MessageBox.Show(""+er);
            }
        }
        //metodo para cambio de password(contraseña)
        public static bool ChangePassword(string email, string password)
        {
            
            try
            {
                cone.Open(); //Abrir la conexion entre el programa y la base de datos 
                string sql = $@"update tblUser set password='{password}' where email='{email}'"; // Es ejecución del funcion en la base de datos 
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cone); //Validar conexion y la funcion del query
                int result = Convert.ToInt32(cmd.ExecuteNonQuery());//Guarda el valor retornado
                sql = $@"update tblUser set password=md5(password)";
                cone.Close();//Cierre de la conexion entre el programa y la base de datos
                if (result == 1)
                {


                    return true;

                }
                else
                {
                    MessageBox.Show("Unknown error");
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }

        }
    }

        
    
}
