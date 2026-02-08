using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque1
{
    public class TIEMPOTRANSCURRIDO
    {
        public TIEMPOTRANSCURRIDO()
        {
            Console.WriteLine("Ingrese la fecha y hora de inicio (formato: hora:minuto:segundo):");
            DateTime fechaInicio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha y hora de fin (formato: hora:minuto:segundo):");
            DateTime fechaFin = DateTime.Parse(Console.ReadLine());

            TimeSpan tiempoTranscurrido = -(fechaFin - fechaInicio);

            Console.WriteLine("Tiempo transcurrido:");
            Console.WriteLine("Horas: " + tiempoTranscurrido.Hours);
            Console.WriteLine("Minutos: " + tiempoTranscurrido.Minutes);
            Console.WriteLine("Segundos: " + tiempoTranscurrido.Seconds);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}