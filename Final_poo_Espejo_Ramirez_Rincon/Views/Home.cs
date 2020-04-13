using System;
using System.Windows.Forms;
using Final_poo_Espejo_Ramirez_Rincon.Classes;
using Final_poo_Espejo_Ramirez_Rincon.Controllers;
using Final_poo_Espejo_Ramirez_Rincon.Models;

namespace Final_poo_Espejo_Ramirez_Rincon.Views
{
    public partial class frmHome : MaterialSkin.Controls.MaterialForm //Referenciamos al material skin formularios
    {
        //Hacemos referencia al controlador de usuario
        UserController login;
         
        /*
         * Realizado por :
         * Juan Pablo Ramirez Gomez
         * Oscar Yesid Restrepo Rincon
         * Noe Sebastián Espejo Correa
         */

        public frmHome()
        {
            login = new UserController();
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            //Oculta un panel home y abre el panel login
            pnlLogin.Visible = true;
            pnlHome.Visible = false;
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            //Oculta un panel home y abre el panel registro
            pnlHome.Visible = false;
            pnlRegistro.Visible = true;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            //Cierra programa
            Close();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            //Oculta un panel login y abre el panel home
            pnlLogin.Visible = false;
            pnlHome.Visible = true;
        }

        private void lblLogin2_Click(object sender, EventArgs e)
        {
            //Mandamos al controlador el correo y la contraseña 
            login.Email = txtEmail.Text;
            login.Password = txtPassword.Text;
            //Hacemos la referencia a la clase encriptar
            string cadenaEncriptada = encrypt.GetMD5(login.Password);
            //Validamos de que el correo exista
            if (clsLogin.TryUser(login.Email) == true)
            {
                //Validamos correo y contraseña
                clsLogin.TryLogin(login.Email, cadenaEncriptada,textBox1);
                
                if (Convert.ToInt32(textBox1.Text) == 1)
                {
                    //Oculta un panel login y abre el panel log out y el label buy
                    this.Hide();
                    new frmAdmin().Show();
                }else if (Convert.ToInt32(textBox1.Text)==2)
                {
                    pnlHome.Visible = false;
                    pnlLogout.Visible = true;
                    lblBuy.Visible = true;
                }
                
                
                
            }
            //Limpiamos el correo y la contraseña
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            //Oculta un panel salir y comprar, y abre el panel inicio, el correo y la contraseña
            pnlLogout.Visible = false;
            login.Email = "";
            login.Password = "";
            lblBuy.Visible = false;
            pnlHome.Visible = true;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblForgotpassword_Click(object sender, EventArgs e)
        {
            //Oculta un panel login y abre el panel actualizar
            pnlUpdate.Visible = true;
            pnlLogin.Visible = false;
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            //Validamos de que las contraseñas ingresadas sean iguales
            if (txtPasswordvalidate.Text==txtPasswordvalidate2.Text)
            {
                //Hacemos referencia a la clase encriptar con el parametro contraseña
                string cadenaconexion = encrypt.GetMD5(txtPasswordvalidate2.Text);
                //Validamos si el cambio de contraseña
                if(clsLogin.ChangePassword(txtEmailvalidate.Text, cadenaconexion) == true)
                {
                    //Mensaje de confirmación 
                    MessageBox.Show("Password has been changed sucessful");
                    //Oculta un panel actualizar y abre el panel home
                    pnlHome.Visible = true;
                    pnlUpdate.Visible = false;
                }
            }
        }

        private void lblBackf_Click(object sender, EventArgs e)
        {
            //Oculta un panel actualizar y abre el panel login
            pnlUpdate.Visible = false;
            pnlLogin.Visible = true;
        }

        private void lblBacks_Click(object sender, EventArgs e)
        {
            //Oculta un panel registro y abre el panel home
            pnlRegistro.Visible = false;
            pnlHome.Visible = true;
        }

        private void lblSignups_Click(object sender, EventArgs e)
        {
            //Validamos que los campos a ingresar no esten vacios
            if (txtDNI.Text==""||txtNames.Text==""||txtSurname.Text==""
                ||txtEmail2.Text==""||txtPasswords.Text==""
                ) 
            {
                //Mensage de advertencia
                MessageBox.Show("Please enter rightly values ");

                } else {

                //Mandamos los datos al controlador 
                login.Name = txtNames.Text;
                login.Last_name = txtSurname.Text;
                login.Dni = txtDNI.Text;
                login.Email = txtEmail2.Text;
                login.Password = txtPasswords.Text;
                //Hacemos referencia a la clase encriptar con el parametro contraseña
                string cadenaencriptada = encrypt.GetMD5(login.Password);
                //Validamos que el email no se encuentre en la base de datos
                if (clsUser.tryemail(login.Email) == true)
                {
                    //Validamos que si se pudieron insertar los datos
                    if (clsUser.tryregistro(login.Name, login.Last_name, login.Dni, login.Email, cadenaencriptada) == true)
                    {
                        //Mensaje de confirmación
                        MessageBox.Show("Signed up successful");
                        //Oculta un panel registro y abre el panel home
                        pnlRegistro.Visible = false;
                        pnlHome.Visible = true;
                    }
                    else
                    {
                        //Mensaje de advertencia
                        MessageBox.Show("try again,please check it out");
                    }
                }
                else
                {
                    //Mensaje de email existente en la base de datos
                    MessageBox.Show("The email already exists");
                    //Limpiamos el text box de correo
                    txtEmail2.Text = "";
                }
            }
        }

        private void lblBuy_Click(object sender, EventArgs e)
        {
            //Oculta el formulario home y abre el formulario buy
            this.Hide();
            new frmBuy().Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
        }

        
        //Declaramos contadores
        int NumImgBill = 0;
        int NumImgPrem = 0;
        int NumImgSoon = 0;

        private void tmrBillboard_Tick(object sender, EventArgs e)
        {
            //Las imagenes se cargaran de acuerdo al vector y al contador NumImgBill
            pcbBillboard.Image = imgLbillboard.Images[NumImgBill];

            if (NumImgBill == imgLbillboard.Images.Count - 1)
            {
                NumImgBill = 0;
            }

            else
            {
                NumImgBill++;
            }
        }

        private void tmrPremiere_Tick(object sender, EventArgs e)
        {
            //Las imagenes se cargaran de acuerdo al vector y al contador NumImgPrem
            pcbPremiere.Image = imgLPremiere.Images[NumImgPrem];

            if (NumImgPrem == imgLPremiere.Images.Count - 1)
            {
                NumImgPrem = 0;
            }

            else
            {
                NumImgPrem++;
            }
        }

        private void tmrSoon_Tick(object sender, EventArgs e)
        {
            //Las imagenes se cargaran de acuerdo al vector y al contador NumImgSoon
            pcbSoon.Image = imgLSoon.Images[NumImgSoon];

            if (NumImgSoon == imgLSoon.Images.Count - 1)
            {
                NumImgSoon = 0;
            }

            else
            {
                NumImgSoon++;
            }
        }
    }
}
