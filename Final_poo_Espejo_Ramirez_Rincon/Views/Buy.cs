using System;
using System.Drawing;
using System.Windows.Forms;
using Final_poo_Espejo_Ramirez_Rincon.Models;


namespace Final_poo_Espejo_Ramirez_Rincon.Views
{
    public partial class frmBuy : MaterialSkin.Controls.MaterialForm
    {
        //Declaramos un contador para el proceso 
        //de seleccion de sillas
        public int i;
        

        public frmBuy()
        {
             InitializeComponent();
            
        }

        //Al escoger las sillas se cambiará de color y se le suma al contador i
        //y a la misma vez se le descontará a lo que haya en las sillas disponibles 
        //Hace refrencia desde la linea 24 hasta 423
        private void btnA1_Click(object sender, EventArgs e)
        {
            if (btnA1.BackColor==Color.Transparent)
            {
                btnA1.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
                
            }
            else
            {
                btnA1.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs+1);
            }
            Nsillas();
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            if (btnA2.BackColor == Color.Transparent)
            {
                btnA2.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();

            }
            else
            {
                btnA2.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);
            }
            Nsillas();
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            if (btnA3.BackColor == Color.Transparent)
            {
                btnA3.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();

            }
            else
            {
                btnA3.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);
            }
            Nsillas();
        }
        private void btnB1_Click(object sender, EventArgs e)
        {
            if (btnB1.BackColor == Color.Transparent)
            {
                btnB1.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();

            }
            else
            {
                btnB1.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);
            }
            Nsillas();
        }
        private void btnB2_Click(object sender, EventArgs e)
        {
            if (btnB2.BackColor == Color.Transparent)
            {
                btnB2.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnB2.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);
            }
            Nsillas();
        }
        private void btnB3_Click(object sender, EventArgs e)
        {
            if (btnB3.BackColor == Color.Transparent)
            {
                btnB3.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnB3.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);
            }
            Nsillas();
        }
        private void btnB4_Click(object sender, EventArgs e)
        {
            if (btnB4.BackColor == Color.Transparent)
            {
                btnB4.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnB4.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);
            }
            Nsillas();
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            if (btnC1.BackColor == Color.Transparent)
            {
                btnC1.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnC1.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);
            }
            Nsillas();
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            if (btnC2.BackColor == Color.Transparent)
            {
                btnC2.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnC2.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);
            }
            Nsillas();
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            if (btnC3.BackColor == Color.Transparent)
            {
                btnC3.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnC3.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);

            }
            Nsillas();
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            if (btnC4.BackColor == Color.Transparent)
            {
                btnC4.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnC4.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);

            }
            Nsillas();
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            if (btnD1.BackColor == Color.Transparent)
            {
                btnD1.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnD1.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);

            }
            Nsillas();
        }
        private void btnD2_Click(object sender, EventArgs e)
        {
            if (btnD2.BackColor == Color.Transparent)
            {
                btnD2.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnD2.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);

            }
            Nsillas();
        }
        private void btnD3_Click(object sender, EventArgs e)
        {
            if (btnD3.BackColor == Color.Transparent)
            {
                btnD3.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnD3.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);
            }
            Nsillas();
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            if (btnD1.BackColor == Color.Transparent)
            {
                btnD4.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnD4.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);
            }
            Nsillas();
        }
        private void btnE1_Click(object sender, EventArgs e)
        {
            if (btnE1.BackColor == Color.Transparent)
            {
                btnE1.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnE1.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);

            }
            Nsillas();
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            if (btnE2.BackColor == Color.Transparent)
            {
                btnE2.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnE2.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);

            }
            Nsillas();
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            if (btnE3.BackColor == Color.Transparent)
            {
                btnE3.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnE3.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);
            }
            Nsillas();
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            if (btnE4.BackColor == Color.Transparent)
            {
                btnE4.BackColor = Color.Gray;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnE4.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);
            }
            Nsillas();
        }

        private void btnP1_Click(object sender, EventArgs e)
        {
            if (btnP1.BackColor == Color.Transparent)
            {
                btnP1.BackColor = Color.Gold;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnP1.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);
            }
            Nsillas();
        }

        private void btnP2_Click(object sender, EventArgs e)
        {
            if (btnP2.BackColor == Color.Transparent)
            {
                btnP2.BackColor = Color.Gold;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnP2.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs+1);
            }
            Nsillas();
        }

        private void btnP3_Click(object sender, EventArgs e)
        {
            if (btnP3.BackColor == Color.Transparent)
            {
                btnP3.BackColor = Color.Gold;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnP3.BackColor = Color.Transparent;
                i --;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);
            }
            Nsillas();
        }

        private void btnP4_Click(object sender, EventArgs e)
        {
            if (btnP4.BackColor == Color.Transparent)
            {
                btnP4.BackColor = Color.Gold;
                i++;
                txtChairsMovie.Text = (Convert.ToInt32(txtChairsMovie.Text) - 1).ToString();
            }
            else
            {
                btnP4.BackColor = Color.Transparent;
                i--;
                int Chairs = Convert.ToInt32(txtChairsMovie.Text);
                txtChairsMovie.Text = Convert.ToString(Chairs + 1);
            }
            Nsillas();
        }

      //Hacemos un metodo para validar que las sillas no sean
      //mayores a la de la seleccion
        public void Nsillas()
        {
            if (i>Convert.ToInt32(txtChairs.Text))
            {
                MessageBox.Show("you have select one chair more,check out your tickets");
            }
            
        }

        
        private void cmbChairs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Segun lo escogido en el combo box silla se abre las group box seleccionado
            if (cmbChairs.Text == "Normal")
            {
                grpChairs.Visible = true;
                grpVIP.Visible = false;
            }
            else
            {
                grpChairs.Visible = false;
                grpVIP.Visible = true;
            }
        }

        private void cmbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpiamos el text box de nombres silla
            txtNameMovie.Text = "";
            //Guardamos el nombre de pelicula en una variable
            string NameMovie=cmbMovies.Text;
            //El texto del text box será igual a la pelicula de combo box peliculas
            txtNameMovie.Text = cmbMovies.Text;
            //El datagridview nos mostrará la imagen de la pelicula seleccionada
            dvgImagen.DataSource = clsMovies.EjecutarQuery($"select image from tblpictures where name='{NameMovie}'", pbImagen.Image);
            int cont = dvgImagen.RowCount;
            for (int i = 0; i < cont; i++)
            {
                dvgImagen.Rows[i].Height = 100;
            }
            //Hacemos referencia a la clsMovies para llenar los respectivos text box
            clsMovies.FillChairs(txtPremiere_Date,txtCountry,txtClasifications,txtDescrptions,txtDuration,txtChairsMovie,NameMovie);
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpiamos los items del combo box peliculas
            cmbMovies.Items.Clear();
            //Guardamos el texto del combo tipo
            string status= cmbType.Text;
            //Hacemos referencia a la clsMovies para llenar el cmbMovies
            clsMovies.FillCmbMovies(cmbMovies,status);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            //Validamos que el numero de sillas no sea mayor a las disponibles
            if (Convert.ToInt32(txtChairs.Text) > Convert.ToInt32(txtChairsMovie.Text))
            {
                MessageBox.Show("Pardon us, we do not have more chairs");
            }
            else
            {
                /*
                 * Segun el tipo de peliculas tendrá un valor diferente 
                 * y nos mostrará un mensaje con el valor a pagar
                 */
                switch (cmbType.Text)
                {
                    case "Coming soon":
                        if (Convert.ToInt32(txtChairs.Text) >= 10)
                        {
                            double pay = 15000 * Convert.ToInt32(txtChairs.Text) * 0.10;
                            double total = (15000 * Convert.ToInt32(txtChairs.Text)) - pay;
                            if (cmbChairs.Text == "VIP")
                            {
                                MessageBox.Show("Chairs " + txtChairs.Text + 
                                    "\n Day " + cmbDay.Text + 
                                    "\n Pay " + (total + (3000 * Convert.ToInt32(txtChairs.Text))).ToString());

                            }
                            else
                            {
                                MessageBox.Show("Chairs " + txtChairs.Text + " Day " + cmbDay.Text + " Pay " + Convert.ToString(total));
                            }
                        }
                        else
                        {
                            if (cmbChairs.Text == "VIP")
                            {
                                MessageBox.Show("Chairs " + txtChairs.Text + " Day " + cmbDay.Text + " Pay " + ((15000 * (Convert.ToInt32(txtChairs.Text)) + (3000 * Convert.ToInt32(txtChairs.Text)))));

                            }
                            else
                            {

                                MessageBox.Show("Chairs " + txtChairs.Text + " Day " + cmbDay.Text + " Pay " + (15000 * Convert.ToInt32(txtChairs.Text)));

                            }
                        }
                        break;

                    case "Billboard":
                        if (cmbDay.Text == "Tuesday" || cmbDay.Text == "Wednesday")
                        {

                            if (cmbChairs.Text == "VIP-Price 3000")
                            {
                                MessageBox.Show("Chairs " + txtChairs.Text + " Day " + cmbDay.Text + " Pay " + ((5250 * Convert.ToInt32(txtChairs.Text)
                                    ) + (3000 * Convert.ToInt32(txtChairs.Text))));

                            }
                            else
                            {
                                MessageBox.Show("Chairs " + txtChairs.Text + " Day " + cmbDay.Text + " Pay " + 5250 * Convert.ToInt32(txtChairs.Text));
                            }
                        }
                        else
                        {
                            if (cmbChairs.Text == "VIP-Price 3000")
                            {
                                MessageBox.Show("Chairs " + txtChairs.Text + " Day " + cmbDay.Text + " Pay " + (10500 * Convert.ToInt32(txtChairs.Text) +
                                (3000 * Convert.ToInt32(txtChairs.Text))));
                            }
                            else
                            {
                                MessageBox.Show("Chairs " + txtChairs.Text + " Day " + cmbDay.Text + " Pay " + (10500 * Convert.ToInt32(txtChairs.Text)));

                            }
                        }
                        break;

                    case "Premiere":
                        if (cmbChairs.Text == "VIP")
                        {
                            MessageBox.Show("Chairs " + txtChairs.Text + " Day " + cmbDay.Text + " Pay " + (12000 * Convert.ToInt32(txtChairs.Text) +
                                (3000 * Convert.ToInt32(txtChairs.Text))));

                        }
                        else
                        {
                            MessageBox.Show("Chairs " + txtChairs.Text + " Day " + cmbDay.Text + " Pay " + (12000 * Convert.ToInt32(txtChairs.Text)));

                        }
                        break;
                }
            }
        }

        private void frmBuy_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
