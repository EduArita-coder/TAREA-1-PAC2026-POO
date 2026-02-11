using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque2
{
    public class CAJEROAUTOMATICO
    {
        int saldo = 5000;
        public CAJEROAUTOMATICO()
        {
            Console.WriteLine("Ingrese el monto a retirar:");
            int monto = int.Parse(Console.ReadLine());
            if(monto % 20 == 0)
            {
                if(monto  < saldo)
                {
                    Console.WriteLine("Retiro exitoso");
                    saldo -= monto;
                    Console.WriteLine("Su saldo actual es: " + saldo);
                    int[] billetes = { 500,100, 50, 20, 10, 5, 2, 1 };
                    Console.WriteLine("Desglose de billetes entregados:");
                    foreach (int billete in billetes)//recorre el arreglo de billetes sin afectarlo porque se usa la variable billete
                    {
                        int cantidad = monto / billete;//calcula la cantidad de billetes necesarios para el monto actual
                        if (cantidad > 0)
                        {
                        Console.WriteLine(cantidad + " billete(s) de " + billete);
                        monto -= cantidad * billete;//restamos la cantidad*billetes para poder seguir con el siguiente billete
                        }
                    } 
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                }
            }
            else
            {
                Console.WriteLine("El monto debe ser múltiplo de 20");
            }
            Console.WriteLine("Gracias por usar el cajero automático");
            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para regresar al menú");
            Console.ReadKey();
            Console.Clear();
           
        }
    }
}