using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque3
{
    public class RANGOPRIMOS
    {
        int num1,num2,i,j;
        int[] billetes = new int[100];
        int Conta = 0,Indice= 0;
        public RANGOPRIMOS()
        {
            do{
            Console.WriteLine("Ingrese un numero para iniciar el rango");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero para finalizar el rango");
            num2 = int.Parse(Console.ReadLine());
            if(num1 == num2)
                {
                    Console.WriteLine("No existe un rango definido porque los numeros son iguales");
                }
                else if (num1 <= 0 || num2 <= 0)
                {
                    Console.WriteLine("No se permiten numeros menores que 1");
                }
            }while(num1 <= 0 || num2 <= 0|| num1 == num2);
            for(i = num1;i <= num2;i++)
            {
                int temporal = i;
                Conta = 0;
                for(j=2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        Conta++;
                    }
                }
                if(Conta == 0)
                {
                    billetes[Indice]= temporal;
                    Indice++;
                }
            }
            Console.Clear();
            Console.WriteLine("<<<<<NUMEROS PRIMOS ENCONTRADOS (Rango : "+num1+" -> "+num2+")>>>>>");
            for(i=0;i<Indice;i++)
            {
                Console.WriteLine(""+billetes[i]);
            }
            Console.WriteLine("Encontrados en total >>> "+ Indice);
            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para continuar....");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}