using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaQuito
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 1;
            while (opcion !=2)
            {
                Console.Clear();
                Console.WriteLine("Programa de prediccion de Pico y Placa en Quito");
                String fecha;
                String placa;
                String hora;
                Console.WriteLine("Ingrese fecha(dd/mm/aaaa):");
                fecha = Console.ReadLine();
                Console.WriteLine("Ingrese placa del auto:");
                placa = Console.ReadLine();
                Console.WriteLine("Ingrese hora (hh:mm:ss 24 format) :");
                hora = Console.ReadLine();




                Auto autoValidado = new Auto(1, placa);

                if (autoValidado.PuedeSalir(fecha, placa, hora))
                {
                    Console.WriteLine("El auto puede circular");
                }
                else
                {
                    Console.WriteLine("El auto no puede circular");
                }

                Console.WriteLine("\nDesea realizar otra consulta?\n");
                Console.WriteLine("1.- Si\n2.-No");
                opcion = Convert.ToInt32(Console.ReadLine());
            }


        }
    }
}
