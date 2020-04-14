using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Final_poo_Espejo_Ramirez_Rincon.Controllers
{
    public class UserController
    {
        //En la clase controlador hacemos referencia a la tabla.
        //tbluser la cual esta se encuentra en la base de datos
        //Encaupsulamos cada variable para mayor seguridad
        private string dni,email,name,last_name, password;

        // Utilizamos la referencia de cada variable para su respectivo acción
        public string Dni { get => dni; set => dni = value; }
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Password { get => password; set => password = value; }
    }

    
}
