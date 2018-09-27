using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaEnteros
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sum2 = 0;
            int[] Sumatoria = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9};  //Arreglo con los primeros 9 numeros naturales

            for (int i = 0; i < 4; i++)
            {
                sum = sum + Sumatoria[i];
            }
           
            for (int j = 0; j < 9; j++)
            {
                sum2 = sum2 + Sumatoria[j];
            }

            Console.WriteLine("\nLa suma de los primeros 4 numeros naturales es: {0} ", sum);
            Console.WriteLine("\nLa suma de los primeros 9 numeros naturales es: {0} ", sum2);

            Console.ReadKey();
        }
    }
}
