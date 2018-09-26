using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.Venegas
{
    class Datos
    {
        int cont = 0, calf = 0, alum = 0;   //Tipos de datos
        int clases;

        public Datos() { }                   // Constructor por defecto

        public Datos(int Cont, int Calf, int Alum, int Clases)
        {
            cont = Cont;
            calf = Calf;
            alum = Alum;
            clases = Clases;
        }

        public int[] Alumnos;              //Vectores
        public int[] Calificaciones;
        public String[] Clases;

        public void Captura()
        {
            Console.Write("Numero de Clases: ");
            clases = int.Parse(Console.ReadLine());

            Clases = new string[clases];    // Vector con el numero de clases asignadas por el usuario
            Alumnos = new int[clases];

            for (int i = 0; i < Clases.Length; i++)  // for para captura de datos
            {
                Console.Write("\nNombre de Clase: ");
                Clases[i] = Console.ReadLine();

                Console.Write("Numero de Alumnos por clase: ");   // Número específico de Alumnos por Clase.
                Alumnos[i] = int.Parse(Console.ReadLine());

                Calificaciones = new int[100];

                for (int j = 1; j <= Alumnos[i]; j++)   //Asignar Calificacion a Alumno
                {
                    Console.Write("{0}. Calificacion de Alumno: ", j);
                    Calificaciones[j] = int.Parse(Console.ReadLine());
                    calf = Calificaciones[j];
                }
                alum = Alumnos[i];
            }

        }
        public void Imprimir()
        {
            foreach (string n in Clases)
            {
                Console.Write("\nLa clase de " + n + " tiene {0}  alumnos", Alumnos[cont]);
                cont++;
            }
            Console.ReadKey();
        }
    }
}
