using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraseña
{
    class Password
    {
        public int longitud { get; set; }
        public string contraseña { get; set; }

        public Password()
        {
            longitud = 0;
            contraseña = "";
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
            this.contraseña = generarPassword(longitud);
        }

        public string generarPassword(int longitud)
        {
            Random r1 = new Random();
            Random r2 = new Random();
            string pass="";
            for (int i = 0; i < longitud; i++)
            {
                int opcion = r1.Next(1, 4);
                switch (opcion)
                {
                    case 1:
                        pass = pass + Convert.ToChar(r2.Next(65, 90));//Mayúsculas
                        break;
                    case 2:
                        pass = pass + Convert.ToChar(r2.Next(97, 122));//Minusculas
                        break;
                    case 3:
                        pass = pass + Convert.ToChar(r2.Next(48, 57));//Numeros
                        break;
                    default:
                        break;
                }
            }
            return pass;
        }

        public Boolean esFuerte(string contra)
        {
            int mayus = 0;
            int minus = 0;
            int num = 0;
            for (int i = 0; i < contra.Length ; i++)
            {
                if (char.IsUpper(contra[i]))
                    mayus++;
                else if (char.IsLower(contra[i]))
                    minus++;
                else
                    num++;
            }
            if (mayus > 2 && minus > 0 && num > 5)
                return true;
            else
                return false;
        }

        public string toString()
        {
            return longitud + " " + contraseña;
        }
    }
}
