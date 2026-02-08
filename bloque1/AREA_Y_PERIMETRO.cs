using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque1
{
    public class AREA_Y_PERIMETRO
    {
        public AREA_Y_PERIMETRO()
        {
            Console.WriteLine("Ingrese el tipo de figura (cuadrado, rectangulo, circulo):");
            string figura = Console.ReadLine().ToLower();

            switch (figura)
            {
                case "cuadrado":
                    Console.WriteLine("Ingrese el lado del cuadrado:");
                    double lado = double.Parse(Console.ReadLine());
                    double areaCuadrado = lado * lado;
                    double perimetroCuadrado = 4 * lado;
                    Console.WriteLine("Área del cuadrado: " + areaCuadrado);
                    Console.WriteLine("Perímetro del cuadrado: " + perimetroCuadrado);
                    break;

                case "rectangulo":
                    Console.WriteLine("Ingrese la base del rectángulo:");
                    double baseRectangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del rectángulo:");
                    double alturaRectangulo = double.Parse(Console.ReadLine());
                    double areaRectangulo = baseRectangulo * alturaRectangulo;
                    double perimetroRectangulo = 2 * (baseRectangulo + alturaRectangulo);
                    Console.WriteLine("Área del rectángulo: " + areaRectangulo);
                    Console.WriteLine("Perímetro del rectángulo: " + perimetroRectangulo);
                    break;

                case "circulo":
                    Console.WriteLine("Ingrese el radio del círculo:");
                    double radio = double.Parse(Console.ReadLine());
                    double areaCirculo = Math.PI * radio * radio;
                    double perimetroCirculo = 2 * Math.PI * radio;
                    Console.WriteLine("Área del círculo: " + areaCirculo.ToString("F2"));
                    Console.WriteLine("Perímetro del círculo: " + perimetroCirculo.ToString("F2"));
                    break;

                default:
                    Console.WriteLine("Figura no reconocida.");
                    break;
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}