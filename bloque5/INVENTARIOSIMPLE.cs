using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque5
{
    public class INVENTARIO
    {
        public INVENTARIO()
        {
            int n = 5;
            string[] codigo = new string[n];
            string[] nombre = new string[n];
            int[] cantidad = new int[n];
            double[] precio = new double[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Producto " + (i+1));
                Console.Write("Codigo: ");
                codigo[i] = Console.ReadLine();
                Console.Write("Nombre: ");
                nombre[i] = Console.ReadLine();
                Console.Write("Cantidad: ");
                cantidad[i] = int.Parse(Console.ReadLine());
                Console.Write("Precio: ");
                precio[i] = double.Parse(Console.ReadLine());
                Console.Clear();
            }

            int opcion;
            do
            {
                Console.WriteLine("1. Mostrar Inventario");
                Console.WriteLine("2. Buscar Producto");
                Console.WriteLine("3. Actualizar Cantidad");
                Console.WriteLine("4. Valor Total Inventario");
                Console.WriteLine("5. Salir");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if(opcion == 1)
                {
                    for(int i = 0; i < n; i++)
                    {
                        Console.WriteLine(codigo[i] + " - " + nombre[i] +
                                          " - Cant: " + cantidad[i] +
                                          " - Precio: " + precio[i]);
                    }
                }
                else if(opcion == 2)
                {
                    Console.Write("Ingrese codigo a buscar: ");
                    string buscar = Console.ReadLine();
                    bool encontrado = false;

                    for(int i = 0; i < n; i++)
                    {
                        if(codigo[i] == buscar)
                        {
                            Console.WriteLine(nombre[i] + 
                                              " - Cant: " + cantidad[i] +
                                              " - Precio: " + precio[i]);
                            encontrado = true;
                        }
                    }

                    if(!encontrado)
                        Console.WriteLine("Producto no encontrado.");
                }
                else if(opcion == 3)
                {
                    Console.Write("Ingrese codigo: ");
                    string buscar = Console.ReadLine();

                    for(int i = 0; i < n; i++)
                    {
                        if(codigo[i] == buscar)
                        {
                            Console.Write("Nueva cantidad: ");
                            cantidad[i] = int.Parse(Console.ReadLine());
                        }
                    }
                }
                else if(opcion == 4)
                {
                    double total = 0;

                    for(int i = 0; i < n; i++)
                        total += cantidad[i] * precio[i];

                    Console.WriteLine("Valor total del inventario: " + total);
                }

                Console.WriteLine("\nPresione una tecla...");
                Console.ReadKey();
                Console.Clear();

            } while(opcion != 5);
        }
    }
}
