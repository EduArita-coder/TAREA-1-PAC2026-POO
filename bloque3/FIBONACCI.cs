using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque3
{
   
    public class FIBONACCI
    {
         int primero = 0, segundo = 1,siguiente,n;
         long acum=0,promedio;
        public FIBONACCI()
        {
            do{
            Console.WriteLine("Cuantos terminos desea generar? : ");
            n = int.Parse(Console.ReadLine());
            if(n <= 0)
                {
                    Console.WriteLine("No se permiten numeros menores que 1 para fibonacci");
                    Console.WriteLine("\nPresione cualquier tecla para continuar");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }while(n <= 0);
            Console.Clear();
            for(int i=1;i<= n;i++)
            {
                Console.WriteLine(primero);
                acum += segundo;
                siguiente = primero + segundo;
                primero = segundo;
                segundo = siguiente;
                
            }
            
            Console.WriteLine("Suma total >>> "+acum);
            promedio = acum/n;
            Console.WriteLine("Promedio >>> "+promedio);
            Console.WriteLine("\nPresione cualquier tecla para continuar....");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}