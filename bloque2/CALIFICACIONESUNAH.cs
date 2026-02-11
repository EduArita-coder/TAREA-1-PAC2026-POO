using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque2
{
    public class CALIFICACIONESUNAH
    {
        double calificacion;
        public CALIFICACIONESUNAH()
        {
            Console.WriteLine("Ingrese su calificacion para determinar su rango de calificacion segun la UNAH");
            calificacion = double.Parse(Console.ReadLine());
            if (calificacion >= 90 && calificacion <= 100)
            {
                Console.WriteLine("Su calificacion es A");
            }
            else if (calificacion >= 80 && calificacion < 90)
            {
                Console.WriteLine("Su calificacion es B");
            }
            else if (calificacion >= 70 && calificacion < 80)
            {
                Console.WriteLine("Su calificacion es C");
            }
            else if (calificacion >= 65 && calificacion < 70)
            {
                Console.WriteLine("Su calificacion es D");
            }
            else if (calificacion >= 0 && calificacion < 65)
            {
                Console.WriteLine("Su calificacion es F");
            }
            else
            {
                Console.WriteLine("Calificacion invalida, ingrese un valor entre 0 y 100");
            }
            if (calificacion < 65)
            {
                Console.WriteLine("Usted ha reprobado");
            }
            else
            {
                Console.WriteLine("Usted ha aprobado con exito");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para regresar al menu anterior");
            Console.ReadKey();
            Console.Clear();
        }
    }
}