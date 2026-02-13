using System;
using System.Net.Security;

namespace TAREA_1_POO.bloque4
{
    public class ESTADCALIFICACIONES
    {
        float[] calificaciones = new float[10];
        int i=0,aprobados=0,desaprobados=0;
        float promedio = 0,acum =0,nota,menor=101,mayor=-1;
        double sumacuadrados=0;
        string entrada= "";
        public ESTADCALIFICACIONES()
        {
            Console.WriteLine("Ingrese Calificaciones (maximo 10)");
            Console.WriteLine("puede presionar j para finalizar");
            do
            {
                entrada = Console.ReadLine();
                 if(entrada == "j")break;
                

                do{                        
                   nota = int.Parse(entrada);
                   calificaciones[i] = nota;

                if(nota>100 || nota<0)
                    {
                        Console.WriteLine("nota fuera de rango");
                    }
                }while(nota> 100|| nota<0);
                acum += calificaciones[i];
                if(nota<menor)menor = nota;
                if(nota>mayor)mayor = nota;
                if(nota>= 65)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
                i++;
                if(i >= 10 )
                {
                    Console.WriteLine("Supero los limites definidos");
                    break;
                }
            }while(entrada != "j" && i <= 10);
            promedio = acum/i;
            for(int j = 0;j<i;j++)
            {
                sumacuadrados += Math.Pow(calificaciones[j]-promedio,2);
            }
            double desviacion = Math.Sqrt(sumacuadrados/i);//desviacion  estandar
            if(i == 0)
            {
                acum = 0;
                menor= 0;
                mayor = 0;
                promedio=0;
                desviacion=0;
            }
            Console.WriteLine("========ESTADISTICAS=======");
            Console.WriteLine($"PROMEDIO:            {promedio:F2}");
            Console.WriteLine("NOTA MAXIMA :        "+mayor);
            Console.WriteLine("NOTA MINIMA:         "+menor);
            Console.WriteLine("APROBADOS:           "+aprobados);
            Console.WriteLine("DESAPROBADOS:        "+desaprobados);
            Console.WriteLine($"DESVIACION ESTANDAR: {desviacion:F2}");
            Console.WriteLine("=============================");
            Console.WriteLine("\npresione enter para salir");
            Console.ReadKey();
            Console.Clear();

        }
    }
}