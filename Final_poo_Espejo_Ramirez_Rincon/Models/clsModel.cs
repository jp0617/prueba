using Final_poo_Espejo_Ramirez_Rincon.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_poo_Espejo_Ramirez_Rincon.Models
{
    //nos permite realizar la conexion entre el programa y la base de datos.
    public abstract class clsModel
    {
        private protected clsDatabase Db { get => clsDatabase.Instance; }

    }
}
