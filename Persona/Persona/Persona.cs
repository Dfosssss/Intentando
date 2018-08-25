using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Persona
    {
        public int edad { get; set; }
        public string nombre { get; set; }
        public string dni { get; set; }
        public string sexo { get; set; }
        public double peso { get; set; }
        public double altura { get; set; }
        public const string sexoD = "H";

        public Persona()
        {
            this.nombre = "";
            this.edad = 0;
            this.sexo = sexoD;
            this.peso = 0;
            this.altura = 0;
        }

        public Persona(string nombre, int edad,string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = 0;
            this.altura = 0;
        }

        public Persona(string nombre, int edad, string sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            generarDNI();
            this.altura = altura;
            comprobarSexo();
        }

        private void comprobarSexo()
        {
            if (sexo != "H" && sexo != "M")
            {
                this.sexo = sexoD;
            }
        }

        public int calcularIMC()
        {
            double pesoideal = peso / (Math.Pow(altura, 2));
            if (pesoideal < 20)
                return -1;
            else if (pesoideal >= 20 && pesoideal <= 25)
                return 0;
            else
                return 1;
        }

        public bool mayorEdad()
        {
            if (edad >= 18)
                return true;
            else
                return false;
        }

        public string toString()
        {
            Console.WriteLine("Información de la persona");
            return "Nombre: "+nombre + " Edad: " + edad + " Sexo: " + sexo + " DNI: " + dni + " Peso (Kg): " + peso + " Altura (M): " + altura;
        }

        private void generarDNI()
        {
            Random r = new Random();
            int aleatorio = 99999999 - r.Next(1, 89999999);
            char letra = Convert.ToChar(r.Next(65,90));
            dni = Convert.ToString(aleatorio) + Convert.ToString(letra);
        }
    }
}
