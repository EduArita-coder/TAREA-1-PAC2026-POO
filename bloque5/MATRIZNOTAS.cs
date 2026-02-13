using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque5
{
    public class MATRIZNOTAS
    {
        int n = 0,NE=0,NPARC=0;
        double promedio = 0 ,acum = 0,mejorestudiante= -1,parcialdificil=1000000;
        public MATRIZNOTAS()
        {
            Console.WriteLine("De Cuantos Estudiantes ingresara la nota?");
            n = int.Parse(Console.ReadLine());
            double[,] estudiantes = new double[n+1,4];
            for(int i = 0;i < n; i++ )
            {
                acum = 0;
                Console.WriteLine("Estudiante N."+(i+1));
                for(int j = 0;j < 3;j++)
                {
                    Console.WriteLine("Nota N."+(j+1)+":");
                    estudiantes[i,j] = int.Parse(Console.ReadLine());
                    acum += estudiantes[i,j];

                }
                promedio = acum/3;
                estudiantes[i,3] = promedio;
                Console.Clear();
            }
            Console.WriteLine("N. de Estudiante\tParcial 1\t parcial 2\t parcial 3\t Promedio");
            for(int i = 0; i < 3; i++)
            {
                acum = 0;
                for(int j = 0; j < n; j++ )
                {
                  acum += estudiantes[j,i];   
                }
                promedio = acum/n;
                estudiantes[n,i] = promedio;
            }
            for(int i = 0;i <= n; i++ )
            {
                if(i == n)
                {
                    Console.Write("Promedio Total: \t");
                    for(int j = 0;j<3;j++)
                    {
                      Console.Write(""+estudiantes[i,j].ToString("F2")+"\t\t "); 
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Estudiante N."+(i+1)+" : \t");
                    for(int j = 0;j < 4;j++)
                    {
                        Console.Write(""+estudiantes[i,j].ToString("F2")+"\t\t ");
                    }
                    Console.WriteLine();
                }

            }
            Console.WriteLine("=============================================================================");
            for(int i = 0;i < 3;i++)
            {
                if(estudiantes[n,i]<parcialdificil)
                {
                    parcialdificil = estudiantes[n,i];
                    NPARC = i;
                }
            }
           for(int j = 0; j < n;j++)
                {
                    if(estudiantes[j,3]> mejorestudiante)
                    {
                        mejorestudiante =estudiantes[j,3];
                        NE = j;
                    }
                }
            Console.WriteLine("Parcial mas dificil : Parcial N."+(NPARC+1));
            Console.WriteLine("Estudiante con mejor nota: Estudiante N."+(NE+1));
             Console.WriteLine("\nPresione Cualquier tecla para continuar");
             Console.ReadKey();
             Console.Clear();
        }

    }
}