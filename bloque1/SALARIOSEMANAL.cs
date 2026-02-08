using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque1
{
    public class SALARIOSEMANAL
    {
        int Horasnormales;
        double Horastrabajadas,PagoExtra,Extras,PagoNormales,tarifahora,Horasextra;
        public SALARIOSEMANAL()
        {
            do{
            Console.WriteLine("Ingrese horas trabajadas: ");
            Horastrabajadas = double.Parse(Console.ReadLine());
            Console.WriteLine("Tarifa por hora : ");
            tarifahora = double.Parse(Console.ReadLine());
            }while(Horastrabajadas < 0|| tarifahora < 0);
            if(Horastrabajadas > 44)
            {
                Horasnormales = 44;
                PagoNormales = 44 * tarifahora;
                PagoExtra = tarifahora*1.5;
                Horasextra = Horastrabajadas - Horasnormales;
                Extras = Horasextra*PagoExtra;

            }
            else
            {
                PagoNormales = Horastrabajadas*tarifahora;
            }
            Console.WriteLine("///////DESGLOSE DE PAGO/////////");
            Console.WriteLine("Horas trabajadas         : "+ Horastrabajadas);
            Console.WriteLine("Horas extra              : "+ Horasextra);
            Console.WriteLine("Pago por horas extra     : "+ Extras);
            Console.WriteLine("Pago por horas normales  : "+ PagoNormales);
            Console.WriteLine("Total                    : "+ (PagoNormales + Extras));
            Console.WriteLine("////////////////////////////////");
            Console.WriteLine(" ");
            Console.WriteLine("Pulsa cualquier tecla para continuar");
            
            Console.ReadKey(true);

        }
    }
}