using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque3
{
    public class FACTORIALYCOMBI
    {
        long resultado1 =1 ,resultado2=1,resultado3=1;
        public FACTORIALYCOMBI()
        {
           
            int opcion;
            int N,n,r;
            do
            {
                Console.WriteLine("Que desea Realizar? :");
                Console.WriteLine("1.Calcular Factorial");
                Console.WriteLine("2.Calcular Combinaciones");
                Console.WriteLine("3.Regresar al menu anterior");
                opcion = int.Parse(Console.ReadLine());
            }while(opcion < 1 || opcion > 3);
            if(opcion == 1)
            {
                Console.WriteLine("Ingrese un numero para calcular factorial");
                N = int.Parse(Console.ReadLine());
                long resultado = 1;
                for(int i = 1 ; i <= N; i++)
                {
                    resultado *= i;
                }
                Console.WriteLine("el factorial de "+ N + "es : "+ resultado);
                Console.WriteLine("\nPresione cualquier tecla para continuar....");
                Console.ReadKey(true);
                Console.Clear();
            }
            if(opcion == 2 )
            {
                do{
                Console.WriteLine("Ingrese un numero n para calcular la combinacion");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Ahora ingrese un valor r : ");
                r = int.Parse(Console.ReadLine());
                if(r > n)
                    {
                        Console.WriteLine("r no puede ser mayor que el numero ingresado anteriormente, intente de nuevo");
                    }
                if(r < 0 || n < 0)
                    {
                        Console.WriteLine("No se permiten numeros negativos, intente de nuevo");
                    }
                }while(r > n || r < 0 || n < 0);
                for(int i = 1 ; i <= (n - r); i++)
                {
                    resultado1 *= i;
                }
                for(int i = 1 ; i <= n; i++)
                {
                    resultado2 *= i;
                }
                for(int i = 1 ; i <= r; i++)
                {
                    resultado3 *= i;
                }
                long t1 = resultado3 * resultado1;
                long total = resultado2/t1;
                Console.Clear();
                Console.WriteLine("La respuesta de C("+n+","+r+") es : "+total);
                Console.WriteLine("\nPresione cualquier tecla para continuar....");
                Console.ReadKey(true);
                Console.Clear();

            }
            if(opcion == 3)
            {
                Console.Clear();
                return;
            }

        }
    }
}