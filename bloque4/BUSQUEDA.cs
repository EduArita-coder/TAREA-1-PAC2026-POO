using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque4
{
    public class BUSQUEDA
    {
        int[] almacenado = {1,15,25,50,100,400,156,500,145,250};
        int buscar,pos,mayor = -1,anterior=-1;
        bool encontrado;
        public BUSQUEDA()
        {
            Console.WriteLine("Que numero desea encontrar de los almacenados");
            buscar = int.Parse(Console.ReadLine());
            for(int i = 0; i < 10;i++)
            {
                if(buscar == almacenado[i])
                {
                    Console.WriteLine("Numero encontrado en la posicion "+i);
                    encontrado = true;
                }
                if(almacenado[i]>mayor)
                {
                    mayor = almacenado[i];
                    pos = i;
                }
            }
            for(int i = 0;i < 10;i++)
            {
                if(i == pos)
                {
                }
                else
                {
                    if(almacenado[i]>anterior)anterior =almacenado[i];
                }
            }
             for (int i = 0; i < 9; i++)
             {
                for (int j = 0; j < 9 - i; j++)
                {
                    if (almacenado[j] > almacenado[j + 1])
                    {
                    int temp = almacenado[j];
                    almacenado[j] = almacenado[j + 1];
                    almacenado[j + 1] = temp;
                    }
                }
            }           
            if(!encontrado)
            {
                Console.WriteLine("Numero no encontrado");
            }
            Console.WriteLine("''''''''''''''''''''''''''");
            Console.WriteLine("Segundo mayor : "+anterior);
            Console.Write("Numeros ordenados en posiciones pares: ");
            for(int i = 0;i < 10; i +=2)
            {
                Console.Write(""+almacenado[i]+", ");
            }
            Console.WriteLine("\nPresione cualquier tecla para salir....");
            Console.ReadKey();
            Console.Clear();
        }
    }
}