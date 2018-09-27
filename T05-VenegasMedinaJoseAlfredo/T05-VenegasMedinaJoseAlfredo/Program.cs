using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TiempoEjecucion
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Stopwatch timeEjecucion = Stopwatch.StartNew();

            for (int i = 1; i <= 1000000; i++) //for para sumar del 1 al 1000000       
            {
                sum = sum + i;
            }
                       
            Console.Write("\nLa suma total es: {0} \nTiempo de ejecucion: {1} ", sum, timeEjecucion.Elapsed);

            Console.ReadKey();
        }
    }
}
