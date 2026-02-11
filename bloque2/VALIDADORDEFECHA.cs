using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TAREA_1_POO.bloque2
{
    public class VALIDADORDEFECHA
    {
        int dia,mes,anio;
        public VALIDADORDEFECHA ()
        {
            Console.WriteLine("Ingrese el dia : ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes : ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año : ");
            anio = int.Parse(Console.ReadLine());

            if (mes < 1 || mes > 12)
            {
                Console.WriteLine("Fecha no valida");
            }
            else
            {
                if (mes == 2)
                {
                    if((anio% 4 == 0 && anio % 100 != 0|| anio % 400 == 0 && dia <= 29))
                    {
                        Console.WriteLine("Fecha valida");
                    }
                    else if(dia <= 28)
                    {
                        Console.WriteLine("Fecha valida");
                    }
                    else
                    {
                        Console.WriteLine("Fecha no valida");
                    }
                }
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dia <= 30)
                    {
                        Console.WriteLine("Fecha valida");
                    }
                    else
                    {
                        Console.WriteLine("Fecha no valida");
                    }
                }
                else
                {
                    if (dia <= 31)
                    {
                        Console.WriteLine("Fecha valida");
                    }
                    else
                    {
                        Console.WriteLine("Fecha no valida");
                    }
                }

            }
            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para regresar al menu");
            Console.ReadKey(); 
            Console.Clear();

        }
    }
}