using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque4
{
    public class ROTACION
    {
            public ROTACION()
            {
                Console.Write("Ingrese el tamaño del arreglo: ");
                int n = int.Parse(Console.ReadLine());

                int[] arreglo = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Posición " + i + ": ");
                    arreglo[i] = int.Parse(Console.ReadLine());
                }

                int opcion;

                do
                {
                    Console.WriteLine("\n1. Rotar K posiciones a la izquierda");
                    Console.WriteLine("2. Rotar K posiciones a la derecha");
                    Console.WriteLine("3. Invertir arreglo");
                    Console.WriteLine("4. Mostrar arreglo");
                    Console.WriteLine("5. Salir");
                    Console.Write("Opción: ");
                    opcion = int.Parse(Console.ReadLine());

                    if (opcion == 1)
                    {
                        Console.Write("Ingrese K: ");
                        int k = int.Parse(Console.ReadLine());
                        k = k % n;

                        for (int r = 0; r < k; r++)
                        {
                            int primero = arreglo[0];
                            for (int i = 0; i < n - 1; i++)
                                arreglo[i] = arreglo[i + 1];
                            arreglo[n - 1] = primero;
                        }
                    }
                    else if (opcion == 2)
                    {
                        Console.Write("Ingrese K: ");
                        int k = int.Parse(Console.ReadLine());
                        k = k % n;

                        for (int r = 0; r < k; r++)
                        {
                            int ultimo = arreglo[n - 1];
                            for (int i = n - 1; i > 0; i--)
                                arreglo[i] = arreglo[i - 1];
                            arreglo[0] = ultimo;
                        }
                    }
                    else if (opcion == 3)
                    {
                        int inicio = 0;
                        int fin = n - 1;

                        while (inicio < fin)
                        {
                            int temp = arreglo[inicio];
                            arreglo[inicio] = arreglo[fin];
                            arreglo[fin] = temp;
                            inicio++;
                            fin--;
                        }
                    }
                    else if (opcion == 4)
                    {
                        Console.Write("Arreglo: ");
                        for (int i = 0; i < n; i++)
                            Console.Write(arreglo[i] + " ");
                        Console.WriteLine();
                    }
                    if(opcion == 5)
                    {
                        Console.Clear();
                    }             

                } while (opcion != 5);
            }
    }
}