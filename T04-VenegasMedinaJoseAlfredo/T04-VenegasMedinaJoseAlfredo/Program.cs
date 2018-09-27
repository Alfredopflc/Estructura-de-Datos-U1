using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos D = new Datos();

            int op;

            do
            {
                Console.Clear();
                try
                {
                    D.Captura();
                    D.Imprimir();
                }

                catch (FormatException e)
                {
                    Console.Write(e.Message);
                }

                Console.WriteLine("\nQuiere volver a iniciar el programa? \n1=Si \n2=No");
                op = int.Parse(Console.ReadLine());

            } while (op == 1);

            Console.Clear();
        }
    }
}
