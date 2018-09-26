using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.VENEGAS
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0, num = 0;
            do
            {
                try
                {
                    Console.Write("Que desea hacer? \n1=Encontrar Valor Mayor o Menor de una Sucesion \n2=Invertir Sucesion" +
                        "\n3=Ultima ocurrencia del elemento mas grande \n4=Encontrar Numero Menor de 3 valores \n5=Primer Elemento Mayor " +
                        "\n6=Elemento Mayor que su Predecesor \n7=Lista de Numeros del 1 al 100 \n8=Palindromo \nR=");
                    op = int.Parse(Console.ReadLine());

                    Console.Clear();

                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("\nMayor o Menor");
                            Console.Write("\nIngrese de cuantos valores desea la sucesion: ");
                            num = int.Parse(Console.ReadLine());

                            double[] Sucesion = new double[num];

                            for (int i = 0; i < num; i++)
                            {
                                Console.Write("Ingrese Numero: ");
                                Sucesion[i] = double.Parse(Console.ReadLine());
                            }

                            Console.WriteLine("\nTu Numero Mayor es: {0} \nTu Numero Menor es: {1}", Sucesion.Max(), Sucesion.Min());

                            break;

                        case 2:
                            Console.WriteLine("\nInvertir Sucesion");
                            Console.Write("Ingresa de cuantos valores desea la sucesion: ");

                            num = int.Parse(Console.ReadLine());
                            string[] Su = new string[num];

                            for (int i = Su.Length - 1; i >= 0; i--)
                            {
                                Console.Write("Ingresar valor: ", i + 1);
                                Su[i] = Console.ReadLine();
                            }

                            Su.Reverse(); //Hacer que la sucesion se invierta

                            Console.WriteLine("\n");

                            foreach (string su in Su)
                            {
                                Console.Write(" {0} ", su);
                            }

                            Console.WriteLine("\nNumero de Valores: {0} ", num);

                            break;

                        case 3:
                            Console.WriteLine("\nNumero mas Grande");

                            Console.Write("Ingrese de cuantos valores desea la sucesion: ");
                            num = int.Parse(Console.ReadLine());

                            double[] Sun = new double[num];

                            for (int i = 0; i < num; i++)
                            {
                                Console.Write("Ingresa valor: ");
                                Sun[i] = double.Parse(Console.ReadLine());
                            }

                            Console.WriteLine("\nLa posicion del Numero Mayor es: {0}\n", (Sun.ToList().LastIndexOf(Sun.Max()) + 1));

                            break;

                        case 4:
                            Console.WriteLine("\nEncontrar Menor");

                            double[] S = new double[3];

                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("Ingrese Numero: ");
                                S[i] = double.Parse(Console.ReadLine());
                            }

                            Console.WriteLine("\nEl Numero Menor es: {0}", S.Min());

                            break;

                        case 5:
                            Console.WriteLine("\nPrimer Elemento Mayor");

                            Console.Write("Ingrese de cuantos valores desea la sucesion: ");
                            num = int.Parse(Console.ReadLine());

                            double[] X = new double[num];

                            for (int i = 0; i < num; i++)
                            {
                                Console.Write("Ingrese valor: ");
                                X[i] = double.Parse(Console.ReadLine());
                            }

                            Console.Write("El Numero Mayor es: {0}", (X.ToList().IndexOf(X.Max()) + 1));

                            break;

                        case 6:
                            Console.WriteLine("Elemento Mayor que su Predecesor");

                            int tamaño = 0, indice = 0;
                            Console.Write("\nIngrese numero de valores de la sucesion: ");
                            tamaño = int.Parse(Console.ReadLine());

                            string[] A = new string[tamaño];

                            for (int i = 0; i < A.GetLength(0); i++ )
                            {
                                Console.Write("Ingrese Valor: ");
                                A[i] = Console.ReadLine();
                            }

                            for(int j = 1; j < A.GetLength (0); j++)
                            {
                                if (A[j].Length > A[j-1].Length)
                                {
                                    indice = j;
                                    j = A.GetLength(0);
                                }
                            }
                            
                            Console.WriteLine("Elemento que es mayor que su predecesor: {0} ", indice + 1);
                          
                            break;

                        case 7:
                            Console.WriteLine("\nLista de Numeros del 1 al 100");

                            Random des = new Random();

                            List<int> Num = new List<int>();

                            Console.WriteLine("\nNumeros en Orden:");

                            for (int i = 1; i <= 100; i++)
                            {
                                Console.Write(" {0} ", i);
                                Num.Add(des.Next(1, 100));
                            }

                            Console.WriteLine("\nNumeros Random:");

                            Num.Reverse();
                            foreach (int n in Num)
                            {
                                Console.Write(" {0} ", n);
                            }

                            Console.WriteLine("\nTotal : {0}", Num.LongCount());
                            break;

                        case 8:
                            Console.WriteLine("Palindromo");

                            int np = 0;
                            Console.Write("\nIngresar 5 digitos: ");

                            np = int.Parse(Console.ReadLine());

                            if (np >= 10000 && np <= 99999)
                            {
                                char[] Z = np.ToString().ToCharArray(); 

                                int pr = int.Parse(Convert.ToString(Z[4]) + //Se convierte en String para que los valores no se sumen
                                    Convert.ToString(Z[3]) +
                                    Convert.ToString(Z[2]) +
                                    Convert.ToString(Z[1]) +
                                    Convert.ToString(Z[0]));

                                if (pr == np)
                                {
                                    Console.WriteLine("\n{0} = {1} , Entonces ES UN PALINDROMO", np, pr);
                                }
                                else
                                {
                                    Console.WriteLine("\n{0} =/= {1} , Entonces NO ES UN PALINDROMO", np, pr);
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNo es posible");
                            }
                            break;

                        //case 9:
                        //    op = 2;
                        //    break;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("\nQuieres volver a iniciar el programa? \n1=Si \n2=No");
                op = int.Parse(Console.ReadLine());
                Console.Clear();

            } while (op == 1);


        }
    }
}

