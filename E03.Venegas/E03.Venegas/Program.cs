using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;

            do
            {
                int sum = 0, sum2 = 0;

                int[] Vector = new int[15]; // Se determina vector con 15 elementos

                try
                {
                    for (int i = 0; i < 15; i++) // for para la captura de datos
                    {
                        Console.Write("Ingresa valor {0}: ", i + 1);
                        Vector[i] = int.Parse(Console.ReadLine());
                    }

                    for (int j = 0; j < 4; j++) // for para la sumatoria de los primeros 4 elementos
                    {
                        sum = sum + Vector[j];
                    }

                    for (int k = 0; k < 9; k++) // for para la sumatoria de los primeros 9 elementos
                    {
                        sum2 = sum2 + Vector[k];
                    }

                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("\nLa suma de los primeros 4 elementos es: {0}", sum);

                Console.WriteLine("\nLa suma de los primeros 9 elementos es: {0} ", sum2);

                Console.WriteLine("\nQuieres volver a iniciar? \n1 = Si \n2 = No");
                op = int.Parse(Console.ReadLine());

                Console.Clear();

            } while (op == 1);

            Console.ReadKey();
        }
    }
} 

