using Final_poo_Espejo_Ramirez_Rincon.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_poo_Espejo_Ramirez_Rincon.Views
{
    public partial class frmAdmin : MaterialSkin.Controls.MaterialForm
    {
        clsAdmin admin = new clsAdmin();
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, System.EventArgs e)
        {
           
            
          
        }

        private void btnInsert_Click(object sender, System.EventArgs e)
        {
            //Limpiamos lo que haya en el datagridview
            dgvPeliculas.ClearSelection();
            //Guardamos los datos que hayan en los text box en sus respectivas variables
            string name=txtName.Text, date=txtDate.Text, cls=txtClasifications.Text
                , cn=txtCountry.Text, dr=txtDurations.Text, st=txtStatus.Text, ds=txtDescriptions.Text;
            int chs=Convert.ToInt32(txtChairs.Text);
            //Metodo insertar del modelo admin
            //admin.Insert(name,date,cls,cn,dr,st,chs,ds);
            //Cargamos los datos que hayan en la base de datos al datagridview
            dgvPeliculas.DataSource = admin.Load();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Guardamos el nombre de la pelicula
            string name = txtName.Text;
            //Metodo eliminar del modelo admin
            //admin.Delete(name);
            //Limpiamos lo que haya en el datagridview
            dgvPeliculas.ClearSelection();
            //Cargamos los datos al datagridview
            dgvPeliculas.DataSource = admin.Load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Limpiamos lo que haya en el datagridview
            dgvPeliculas.ClearSelection();
            //Guardamos el nombre de la pelicula 
            string name = txtName.Text;
            //Cargamos los datos en sus respectivos text box
            //admin.llenar(name,txtDate,txtClasifications,txtCountry,txtDurations,txtStatus,txtChairs,txtDescriptions,btnUpdate2);
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            //Cargamos los datos a los datagridview
            dgvPeliculas.DataSource = admin.Load();
            //dgvImagen.DataSource = clsAdmin.EjecutarQuery(@"Select * from tblpictures",pbImagen.Image);
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            //Guardamos los datos en sus respectivas variables
            string name = txtName.Text, date = txtDate.Text, cls = txtClasifications.Text
               , cn = txtCountry.Text, dr = txtDurations.Text, st = txtStatus.Text, ds = txtDescriptions.Text;
            int chs = Convert.ToInt32(txtChairs.Text);

            //Metodo actulizar del modelo admin
            //admin.Update(name, date, cls, cn, dr, st, chs, ds,btnUpdate2);
            dgvPeliculas.ClearSelection();
            //Actualizamos el datagridview
            dgvPeliculas.DataSource = admin.Load();
        }

        public OpenFileDialog examinar = new OpenFileDialog();

        private void btnShow_Click(object sender, EventArgs e)
        {
            //Metodo para buscar las imagenes y mostrar en el picture box
            examinar.Filter = "image files |*.jpg; *.png;";
            DialogResult r = examinar.ShowDialog();
            if (r == DialogResult.Abort)
            {
                return;
            }
            if (r == DialogResult.Cancel)
            {
                return;
            }
            pbImagen.Image = Image.FromFile(examinar.FileName);
        }

        private void dgvImagen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            //Guardamos el nombre de la pelicula 
            string nombre = txtName.Text;
            //Realizamos el query
            string sql = $@"insert into tblpictures values ('{nombre}',@Imagen)";
            //LLamamos el model admin funcion ejecutar 
            //clsAdmin.EjecutarQuery(sql, pbImagen.Image);
            //Recargamos el datagridview de peliculas
            //dgvImagen.DataSource = clsAdmin.EjecutarQuery("select * from tblpictures", pbImagen.Image);
            int cont = dgvImagen.RowCount;
            for (int i = 0; i < cont; i++)
            {
                dgvImagen.Rows[i].Height = 100;
            }
        }

        private void btnUpadteimage_Click(object sender, EventArgs e)
        {
            //Guardamos el nombre de la pelicula
            string nombre = txtName.Text;
            //Realizamos query
            string sql = $@"update tblpictures set image=@image";
            //Llamamos al ejecutar query del modelo admin
            //clsAdmin.EjecutarQuery(sql, pbImagen.Image);
            //Actualizamos el datagridview
            //dgvImagen.DataSource = clsAdmin.EjecutarQuery(@"select * from tblpictures", pbImagen.Image);
            int cont = dgvImagen.RowCount;
            for (int i = 0; i < cont; i++)
            {
                dgvImagen.Rows[i].Height = 100;
            }
        }

        private void dgvPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
