using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque1
{
    public class BILLETES
    {
        public BILLETES()
        {
             Console.WriteLine("Ingrese el monto a desglosar:");
              int monto = int.Parse(Console.ReadLine());
              int[] billetes = { 500,100, 50, 20, 10, 5, 2, 1 };
              Console.WriteLine("Desglose de billetes:");
              foreach (int billete in billetes)//recorre el arreglo de billetes sin afectarlo porque se usa la variable billete
                {
                    int cantidad = monto / billete;//calcula la cantidad de billetes necesarios para el monto actual
                    if (cantidad > 0)
                    {
                    Console.WriteLine(cantidad + " billete(s) de " + billete);
                    monto -= cantidad * billete;//restamos la cantidad*billetes para poder seguir con el siguiente billete
                    }
                }            
        }
    }
}