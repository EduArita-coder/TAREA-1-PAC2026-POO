using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque3
{
    public class PATRONASTERISCO
    {
        int opc,size,n;
        public PATRONASTERISCO()
        {
            do
            {
                Console.WriteLine("BIENVENIDO AL MENU DE GENERACION DE FIGURAS");
                Console.WriteLine("Elige una opcion a continuacion:");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("1.Triangulo");
                Console.WriteLine("2.Triangulo Invertido");
                Console.WriteLine("3.Rombo");
                Console.WriteLine("4.Cuadrado Hueco");
                Console.WriteLine("5.Regresar al menu anterior");
                Console.WriteLine("-------------------------------------------");
                opc = int.Parse(Console.ReadLine());
                Console.Clear();
            }while(opc > 5|| opc < 0);
                Console.Clear();
                switch(opc)
                {
                case 1:
                    {
                        do{
                        Console.WriteLine("Ahora ingrese el tamano que tendra");
                        size = int.Parse(Console.ReadLine());
                        }while(size < 0);
                        for(int i = 1;i <= size;i++)
                        {
                            for(int j = 0; j<i;j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                case 2:
                    {
                        do{
                        Console.WriteLine("Ahora ingrese el tamano que tendra");
                        size = int.Parse(Console.ReadLine());
                        }while(size < 0);
                        for(int i = size;i > 0;i--)
                        {
                            for(int j = 0; j < i;j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                case 3:
                    {
                        do{
                        Console.Write("Ingrese la altura (número impar): ");
                        n = int.Parse(Console.ReadLine());
                        }while(n % 2 == 0);

                        // Parte superior
                        for (int i = 1; i <= n; i += 2)
                        {
                            // Espacios
                            for (int j = n; j > i; j -= 2)
                            {
                                Console.Write(" ");
                            }

                            // Asteriscos
                            for (int k = 1; k <= i; k++)
                            {
                                Console.Write("*");
                            }

                            Console.WriteLine();
                        }

                        // Parte inferior
                        for (int i = n - 2; i >= 1; i -= 2)
                        {
                            // Espacios
                            for (int j = n; j > i; j -= 2)
                            {
                                Console.Write(" ");
                            }

                            // Asteriscos
                            for (int k = 1; k <= i; k++)
                            {
                                Console.Write("*");
                            }

                            Console.WriteLine();
                        }
                        break;
                    }
                case 4:
                        {
                            Console.Write("Ingrese el tamaño del lado: ");
                            int n = int.Parse(Console.ReadLine());

                            for (int i = 1; i <= n; i++)
                            {
                                for (int j = 1; j <= n; j++)
                                {
                                    if (i == 1 || i == n || j == 1 || j == n)
                                    {
                                        Console.Write("*"); // Bordes
                                    }
                                    else
                                    {
                                        Console.Write(" "); // Interior vacío
                                    }
                                }

                              Console.WriteLine(); // Salto de línea al terminar la fila
                            }
                        break;
                         }
                }
        }
    }
} 
