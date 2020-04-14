using System.Data;
using Npgsql;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Drawing;

namespace Final_poo_Espejo_Ramirez_Rincon.Controllers
{
    class clsAdmin : clsModel
    {
        //Declaramos variables 
        //Variables que contengan npgsql son variables de base de datos 
        //public static NpgsqlConnection cone = Database.clsDatabase.Instance.Connection;
        public static NpgsqlCommand cmd;
        public static string sql;
        public static NpgsqlDataReader dr;
        public static NpgsqlDataAdapter da = new NpgsqlDataAdapter();
        public static DataTable dt = new DataTable();
        //Nos organiza los datos para mostrar en el datagridview*
        public static DataSet ds = new DataSet();

        public DataTable Load()
        {
            //Atrapamos posibles error si estos existen 
            try
            {
                //Abrimos conexión entre el programa y la base de datos
                Db.Connection.Open();
                //Hacemos el query
                sql = @"select * from tblMovies";
                //Mandamos el query y la conexión
                da.SelectCommand = new NpgsqlCommand(sql, Db.Connection);
                //Nos organiza los datos en el dataset
                da.Fill(ds);
                //Hacemos el datatable igual al dataset organizado
                dt = ds.Tables[0];
                //Cerramos la conexion entre el programa y la base de datos
                Db.Connection.Close();
                
            }
            catch (Exception er)
            {
                MessageBox.Show(""+er);
            }
            //Nos retorna el datatable
            return dt;
        }
        /*
        public void Insert(string name,string premiere,string cls,string cn,string dr,string st,int chs,string ds)
        {
            try
            {

                cone.Open();

                //Con este query guardamos los datos nuevos
                //1. Nombre pelicula, 2.fecha de lanzamiento, 3. clasificacion, 4. duracion,
                //5. estatus, 6. sillas, 7. descripción
                sql = $@"insert into tblMovies values('{name}','{premiere}','{cls}','{cn}','{dr}','{st}',{chs},'{ds}')";
                //Ejecutamos el query
                cmd = new NpgsqlCommand(sql, cone);
                //Reforzamos la instrucción
                cmd.ExecuteNonQuery();

                cone.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(""+er);
            }
        }

        public void Delete(string name)
        {
            try
            {
                cone.Open();
                sql = $@"delete from tblMovies where name='{name}'";
                //Eliminar la fila donde se encuentre el nombre
                cmd = new NpgsqlCommand(sql, cone);
                cmd.ExecuteNonQuery();
                cone.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(""+er);
            }
        }

        public void llenar(string name,TextBox premiere, TextBox cls, TextBox cn, 
            TextBox dur, TextBox st, TextBox chs, TextBox ds,MaterialFlatButton btn
            )
        {
            try
            {
                cone.Open();
                sql = $@"select premiere_date,country,clasifications,descriptions,durations,status,chairs from tblMovies where name='{name}'";
                cmd = new NpgsqlCommand(sql, cone);
                //Nos va a leer el resultado del query 
                dr = cmd.ExecuteReader();
                //Mientras haya datos nos los lee y muestra en sus textbox respectivos
                while (dr.Read())
                {
                    premiere.Text = dr["premiere_date"].ToString();
                    cls.Text = dr["clasifications"].ToString();
                    cn.Text = dr["country"].ToString();
                    dur.Text = dr["durations"].ToString();
                    st.Text = dr["status"].ToString();
                    chs.Text = dr["chairs"].ToString();
                    ds.Text = dr["descriptions"].ToString();
                }
               
                cone.Close();
                btn.Visible = true;
            }catch(Exception er)
            {
                MessageBox.Show(""+er);
            }
            
        }

        public void Update(string name, string premiere, string cls, string cn, string dr, string st, int chs, string ds,MaterialFlatButton bn)
        {
            cone.Open();
            sql = $@"update tblMovies set premiere_date='{premiere}',clasifications = '{cls}',country='{cn}',durations='{dr}',
                   status='{st}',chairs='{chs}',descriptions='{ds}' where name='{name}'";
            cmd = new NpgsqlCommand(sql, cone);
            int cant = cmd.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Dates has been changed");
            }
            else
            {
                MessageBox.Show("Error unknown");
            }
            cone.Close();
            bn.Visible = false;

        }
        public static DataTable EjecutarQuery(string sql,Image img)
        {
            
            //creamos una memoria en stream
            MemoryStream ms = new MemoryStream();
            try
            {
               // img.Save(ms, img.RawFormat);
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
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cone);
            //cmd.ExecuteNonQuery();
            //adaptamos el query. en el dataadapter
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
                //Se cierra obligado
                cone.Close();
            }
            //retornar los bytes que corresponden a la imagen.
            return dt;

        }
        */

    }
}
