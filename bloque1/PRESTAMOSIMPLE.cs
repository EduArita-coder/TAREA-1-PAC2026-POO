using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque1
{
    public class PRESTAMOSIMPLE
    {
        public PRESTAMOSIMPLE()
        {
            Console.WriteLine("Ingrese el monto del préstamo:");
            double monto = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tasa de interés anual (en porcentaje):");
            double tasaInteres = double.Parse(Console.ReadLine()) / 100;
            Console.WriteLine("Ingrese el plazo del préstamo en años:");
            int plazoAnios = int.Parse(Console.ReadLine());

            double interesSimple = monto * tasaInteres * plazoAnios;
            double montoTotal = monto + interesSimple;
            double montomensual = montoTotal / (plazoAnios * 12);

            Console.WriteLine("El interés total simple es: " + interesSimple);
            Console.WriteLine("El monto total a pagar es: " + montoTotal);
            Console.WriteLine("El monto mensual a pagar es: " + montomensual);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}