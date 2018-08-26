using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Contraseña
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Password p = new Password(10);
            Console.WriteLine(p.toString());
            Console.WriteLine(p.esFuerte(p.contraseña));*/

            Console.Write("Indica el tamaño del arreglo: "); int tamañoArreglo = Convert.ToInt32(Console.ReadLine());
            var contras = new Password[tamañoArreglo];
            var fuertes = new bool[tamañoArreglo];
            Console.Write("Indica el tamaño de las contraseñas: "); int tamañoContras = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            /*Console.WriteLine("Generando contraseñas"); Thread.Sleep(500); Console.Clear();
            Console.WriteLine("Generando contraseñas ."); Thread.Sleep(500); Console.Clear();
            Console.WriteLine("Generando contraseñas . ."); Thread.Sleep(500); Console.Clear();
            Console.WriteLine("Generando contraseñas . . ."); Thread.Sleep(500); Console.Clear();*/

            for (int i = 0; i < contras.Length ; i++)
            {
                //Console.Write("Tamaño para la contraseña "+(i+1)+" : ");
                contras[i] = new Password(tamañoContras);//Convert.ToInt32(Console.ReadLine())
            }

            for (int i = 0; i < contras.Length ; i++)
            {
                fuertes[i] = contras[i].esFuerte(contras[i].contraseña);
            }

            Console.WriteLine("Contraseñas: ");

            for (int i = 0; i < contras.Length; i++)
            {
                Console.WriteLine((i+1)+" "+ contras[i].contraseña+" "+fuertes[i] );
            }



            Console.ReadKey();
            
        }
    }
}
