using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque4
{
    public class FRECUENCIA
    {
       int frecuencia = 0,mayor=-1,menor=100,posMen,posMay;
        public FRECUENCIA()
        {
            Random aleatorio = new Random();
            int [] arreglo1= new int[20];
            int [] arreglo2 = {1,2,3,4,5,6,7,8,9,10};
            int [] arreglo3 = new int[20];
        
            for(int i=0;i < 20;i++)
            {
                int numero = aleatorio.Next(1,10);
                arreglo1[i] = numero;
            }
            for(int i =0;i <10;i++)
            {
                frecuencia=0;
                for(int j = 0;j < 20;j++)
                {
                    if(arreglo2[i]== arreglo1[j])
                    {
                        frecuencia++;
                    }
                }
                arreglo3[i]= frecuencia;
                if(frecuencia>mayor)
                {
                    mayor = frecuencia;
                    posMay = i;
                }
                if(frecuencia<menor)
                {
                    menor = frecuencia;
                    posMen = i;
                }
            }
            Console.WriteLine("FRECUENCIA DE CADA NUMERO ALEATORIO");
            for(int i = 0;i<10;i++)
            {
                Console.WriteLine(""+(i+1)+".  = "+arreglo3[i]);
            }
            Console.WriteLine("==================");
            Console.WriteLine("Numero con mayor frecuencia = "+arreglo2[posMay]);
            Console.WriteLine("Numero con menor frecuencia = "+arreglo2[posMen]);
            Console.WriteLine("\n Pulsa cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}