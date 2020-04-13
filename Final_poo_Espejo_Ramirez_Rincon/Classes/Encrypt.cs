//estas son las librerias que llamamos para encriptar las passwords
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Final_poo_Espejo_Ramirez_Rincon.Classes
{

    public class encrypt
    {    
        // con esta clase se genera una cadena de 80 caracteres que codifica 
        //la contraseñe para ser un codigo en md5
        //Se hace para mayor seguridad de los usuarios que crean contraseñas vulnerables
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            //Nos retorna la cadena encriptada 
            return sb.ToString();
        }
    }
}
