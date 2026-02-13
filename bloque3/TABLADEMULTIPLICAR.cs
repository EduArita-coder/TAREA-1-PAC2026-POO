using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque3
{
    public class TABLADEMULTIPLICAR
    {
        int numero,i;
        public TABLADEMULTIPLICAR()
        {
            do{
            Console.WriteLine("Ingrese un numero para crear la tabla de multiplicar:");
            numero = int.Parse(Console.ReadLine());
            if(numero < 0)
                {
                    Console.WriteLine("No se permiten numeros menores que 0, intente de nuevo");
                }
            Console.Clear();
            }while(numero < 0);
            Console.WriteLine("TABLA DE MULTIPLICAR");
            for(i = 1; i <= 12; i++)
            {
                Console.WriteLine(numero + "x"+ i +"="+(numero*i));
            }
            Console.WriteLine("========================");
            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para continuar....");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}