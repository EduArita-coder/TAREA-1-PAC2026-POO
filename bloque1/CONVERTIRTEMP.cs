using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque1
{
    public class CONVERTIRTEMP
    {
        int opcion = 0;
        public CONVERTIRTEMP()
        {
            do{
            Console.WriteLine("Que desea convertir?");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Celsius a Kelvin");
            Console.WriteLine("4. Kelvin a Celsius");
            Console.WriteLine("5. Fahrenheit a Kelvin");
            Console.WriteLine("6. Kelvin a Fahrenheit");
            Console.WriteLine("7. Regresar al menu anterior");
            opcion = int.Parse(Console.ReadLine());
            }while(opcion < 1 || opcion > 7);
            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese la temperatura en Celsius:");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine("Resultado : "+ celsius + " °C son " + fahrenheit + " °F");
                    break;
                case 2:
                    Console.WriteLine("Ingrese la temperatura en Fahrenheit:");
                    fahrenheit = double.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine("Resultado : "+ fahrenheit + " °F son " + celsius + " °C");
                    break;
                case 3:
                    Console.WriteLine("Ingrese la temperatura en Celsius:");
                    celsius = double.Parse(Console.ReadLine());
                    double kelvin = celsius + 273.15;
                    Console.WriteLine("Resultado : "+ celsius + " °C son " + kelvin + " K");
                    break;
                case 4:
                    Console.WriteLine("Ingrese la temperatura en Kelvin:");
                    kelvin = double.Parse(Console.ReadLine());
                    celsius = kelvin - 273.15;
                    Console.WriteLine("Resultado : "+ kelvin + " K son " + celsius + " °C");
                    break;
                case 5:
                    Console.WriteLine("Ingrese la temperatura en Fahrenheit:");
                    fahrenheit = double.Parse(Console.ReadLine());
                    kelvin = (fahrenheit - 32) * 5 / 9 + 273.15;
                    Console.WriteLine("Resultado : "+ fahrenheit + " °F son " + kelvin + " K");
                    break;
                case 6:
                    Console.WriteLine("Ingrese la temperatura en Kelvin:");
                    kelvin = double.Parse(Console.ReadLine());
                    fahrenheit = (kelvin - 273.15) * 9 / 5 + 32;
                    Console.WriteLine("Resultado : "+ kelvin + " K son " + fahrenheit + " °F");
                    break;
                case 7:
                    Console.WriteLine("Saliendo...");
                    break;
            }
        }
    }
}