using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque2
{
    public class AÑOBISIESTO
    {
        int anio;
        public AÑOBISIESTO()
        {
            Console.WriteLine("Ingrese Un año para determinar si fue bisiesto o no");
            anio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ahora Ingrese un mes para determinar cuantos dias tuvo ese mes");
            string mes = Console.ReadLine().ToLower();
            if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
            {
                Console.WriteLine("El año " + anio + " es bisiesto.");
            }
            else
            {
                Console.WriteLine("El año " + anio + " no es bisiesto.");
            }
            switch (mes)
            {
                case "enero":
                case "marzo":
                case "mayo":
                case "julio":
                case "agosto":
                case "octubre":
                case "diciembre":
                    Console.WriteLine("El mes de " + mes + " tiene 31 días.");
                    break;
                case "abril":
                case "junio":
                case "septiembre":
                case "noviembre":
                    Console.WriteLine("El mes de " + mes + " tiene 30 días.");
                    break;
                case "febrero":
                    if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
                    {
                        Console.WriteLine("El mes de febrero tiene 29 días.");
                    }
                    else
                    {
                        Console.WriteLine("El mes de febrero tiene 28 días.");
                    }
                    break;
                default:
                    Console.WriteLine("Mes no válido.");
                    break;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}