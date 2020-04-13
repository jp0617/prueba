using Npgsql;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing;



namespace Final_poo_Espejo_Ramirez_Rincon.Models
{
    //hacemos la conexion del programa a la base de datos.
    public class clsMovies : clsModel
    {
        //declaramos variablos de base de dato.
        public static NpgsqlConnection cone = Database.clsDatabase.Instance.Connection;
        public static NpgsqlCommand cmd;
        public static NpgsqlDataReader dr;
        public static string sql;

        //llenamos el cmbMovies con lo seleccionados en cmbTipo
        //mandamos la referencia del combobox peliculas y lo que haya
        //en el texto del comoboxtipos
        public static void FillCmbMovies(ComboBox cb, string status)
        {

            //con el try validamos el nombre de las peliculas, donde
            //el tipo de pelicula sea el que seleccione en el combobox como box tipos
            try
            {
              //abrir conexion entre el programa y la base de datos
                cone.Open();
                //realizamos el query para el llenado de peliculas
                sql = $@"select name from tblMovies where status='{status}'";
                //mandamos el query mas la conexion
                cmd = new NpgsqlCommand(sql, cone);
                //leemos el resultado del query
                dr = cmd.ExecuteReader();
                //con el while llenamos el combobox de las peliculas existente por el status
                while (dr.Read())
                {
                    cb.Items.Add(dr["Name"].ToString());
                }
                //cierra la conexion entre la aplicacion y la base de datos.
                cone.Close();
            } catch (Exception er)
            {
                MessageBox.Show("Unknown error " + er);
            }
        }
        //lo ejecutamos para mostrar las imagenes.
        public static DataTable EjecutarQuery(string Q,Image img)
        {
            //creamos una memoria en stream
            MemoryStream ms = new MemoryStream();
            try
            {
                //img.Save(ms, img.RawFormat);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            //creamos un vector de bytes, para guardar los bytes.
            byte[] imagenes = ms.GetBuffer();
            //creamos un datatable para subir en el datagridview.
            DataTable dt = new DataTable();
            //mandamos conexion+query. 
            NpgsqlCommand cmd = new NpgsqlCommand(Q, cone);
            //adaptamos el query. en el datadata
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            //mandamos la imagen como parametro.
            cmd.Parameters.AddWithValue("@Imagen", imagenes);
            //abrimos la conexion, llenamos datagridview y se cierra la conexion.
            try
            {
                cone.Open();
                da.Fill(dt);
                cone.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                cone.Close();
            }
            //retornar los bites de la imagen.
            return dt;

        }
        //se llena la informacion de la pelicula.
        //mandamos cada textbox con su respectivo referencia y el nombre de la pelicula
        public static void FillChairs(TextBox dt,TextBox cn,TextBox cl,TextBox des,TextBox du,TextBox ch,string NameMovie)
        {
            
            try
            { 
                //abrimos conexión entre el programa y la base de datos.
                cone.Open();
                //query para los elementos que se piden del formulario
                sql = $@"select premiere_date,country,clasifications,descriptions,durations,chairs from tblMovies where name='{NameMovie}'";
                //mandamos el query mas la conexion.
                cmd = new NpgsqlCommand(sql, cone);
                //ejecutamos y guardamos los resultado del query en sus respectivos textbox.
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   
                    dt.Text = dr["premiere_date"].ToString();
                    cn.Text = dr["Country"].ToString();
                    cl.Text = dr["Clasifications"].ToString();
                    des.Text = dr["descriptions"].ToString();
                    du.Text = dr["durations"].ToString();
                    ch.Text=dr["Chairs"].ToString();
                }
                //cierre de conexion. entre el programa y la base de datos
                cone.Close();
            }catch (Exception er)
            {
                //Si se generar un error este lo mostrará
                MessageBox.Show("Unknown error"+er);
            }
        }
        
        
        
        
    }
}
