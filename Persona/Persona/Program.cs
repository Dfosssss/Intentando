using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca los datos de la persona 1");
            Console.Write("Nombre: "); string n1 = Console.ReadLine();
            Console.Write("Edad: "); int e1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sexo: "); string s1 = Console.ReadLine();
            Console.Write("Peso (Kg): "); double p1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Altura (M): "); double a1 = Convert.ToDouble(Console.ReadLine());
            Persona per1 = new Persona(n1, e1, s1, p1, a1);
            comprobarIMC((per1.calcularIMC()));
            Console.WriteLine(per1.toString());
            Thread.Sleep(3000);
            Console.Clear();

            Console.WriteLine("Introduzca los datos de la persona 2");
            Console.Write("Nombre: "); string n2 = Console.ReadLine();
            Console.Write("Edad: "); int e2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sexo: "); string s2 = Console.ReadLine();
            Persona per2 = new Persona(n2, e2, s2);
            Console.WriteLine(per2.toString());
            Thread.Sleep(3000);


            Console.ReadKey();
        }

        public static void comprobarIMC(int peso)
        {
            switch (peso)
            {
                case -1:
                    Console.WriteLine("El peso de la persona está por debajo de lo ideal");
                    break;
                case 0:
                    Console.WriteLine("La persona tiene un peso ideal");
                    break;
                case 1:
                    Console.WriteLine("La persona tiene sobrepeso");
                    break;
                default:
                    Console.WriteLine("Peso invalido");
                    break;
            }
        }
    }
}
