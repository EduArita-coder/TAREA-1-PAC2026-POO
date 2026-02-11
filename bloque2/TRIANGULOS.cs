using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque2
{
    public class TRIANGULOS
    {
        double lado1, lado2, lado3, angulo1, angulo2, angulo3;
        public TRIANGULOS()
        {
            do{
            Console.WriteLine("Ingrese los 3 lados del triangulo");
            Console.WriteLine("Lado 1:");
            lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Lado 2:");
            lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Lado 3:");
            lado3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ahora ingrese los angulos del triangulo");
            Console.WriteLine("Angulo 1:");
            angulo1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Angulo 2:");
            angulo2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Angulo 3:");
            angulo3 = double.Parse(Console.ReadLine());
                if (angulo1 + angulo2 + angulo3 != 180)
                {
                Console.WriteLine("La suma de los angulos debe ser igual a 180 grados, por favor ingrese los datos nuevamente");
                }
                else if (lado1 + lado2 <= lado3 || lado1 + lado3 <= lado2 || lado2 + lado3 <= lado1)
                {
                Console.WriteLine("La suma de dos lados debe ser mayor que el tercer lado, por favor ingrese los datos nuevamente");
                }

            }while (lado1 <= 0 || lado2 <= 0 || lado3 <= 0 || angulo1 <= 0 || angulo2 <= 0 || angulo3 <= 0|| angulo1 + angulo2 + angulo3 != 180);
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triangulo es equilatero");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                Console.WriteLine("El triangulo es isosceles");
            }
            else
            {
                Console.WriteLine("El triangulo es escaleno");
            }
            if(angulo1 == 90 || angulo2  == 90|| angulo3 == 90)
            {
                Console.WriteLine("El triangulo es rectangulo");
            }
            else if (angulo1 > 90 || angulo2 > 90 || angulo3 > 90)
            {
                Console.WriteLine("El triangulo es obtusangulo");
            }
            else
            {
                Console.WriteLine("El triangulo es acutangulo");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

        }
    }
}