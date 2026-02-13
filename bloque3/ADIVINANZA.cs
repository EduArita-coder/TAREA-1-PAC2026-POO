using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque3
{
    public class ADIVINANZA
    {
        int intento = 0,Numerocliente;
            public ADIVINANZA()
        {
            Random aleatorio = new Random();
            int numero = aleatorio.Next(1,101);
           // Console.WriteLine(numero);
            do{
                Console.WriteLine("Bienvenido al Juego de Adivinanza, por favor ingrese un numero para intentar adivinar(intentos :"+(7 -intento)+")");
                Numerocliente = int.Parse(Console.ReadLine());
                if(Numerocliente == numero)
                {
                    Console.Clear();
                    Console.WriteLine("Felicidades, Advinaste el numero");
                    Console.WriteLine("Presione Enter para ver las estadisticas..");
                    Console.ReadKey();
                    intento++;
                }
                else
                {
                    if(Numerocliente > numero)
                    {
                        Console.WriteLine("El numero a adivinar es menor");
                        intento++;
                     }
                   else
                    {
                    Console.WriteLine("El numero a adivinar es mayor");
                    intento ++;
                    }
                }
                if(intento == 7)
                {
                    Console.Clear();
                    Console.WriteLine("gracias por participar");
                    Console.WriteLine("Presione Enter para ver las estadisticas..");
                    Console.ReadKey();
                }
            }while(Numerocliente!= numero && intento != 7);
            Console.Clear();
            Console.WriteLine(">>>>>>>>>ESTADISTICAS>>>>>>>");
            Console.WriteLine("Intentos Realizados : "+ intento);
            Console.WriteLine("Numero a adivinar : "+numero);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("\nPresione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}