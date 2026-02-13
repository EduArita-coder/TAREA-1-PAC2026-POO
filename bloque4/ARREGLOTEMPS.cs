using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque4
{
    public class ARREGLOTEMPS
    {
        int [] diasT = new int[7];
        int [] dia = {1,2,3,4,5,6,7};
        int [] quedia = new int[7];
        int mayortemp=-1,menortemp=1000,variacion,diferencia,acumd=0,k=0,Dmayortemp,Dmenortemp;
        double promedio,acum;
        public ARREGLOTEMPS()
        {
            Console.WriteLine("Ingrese las temperaturas de 7 dias en grados");
            for(int i = 0; i< 7;i++)
            {
                Console.Write("Dia "+(i+1)+": ");
                diasT[i] = int.Parse(Console.ReadLine());
                acum += diasT[i];
            }
            promedio = acum/7;
            for(int i = 0;i<7;i++)
            {
                if(diasT[i] > promedio)
                {
                    quedia[k] = i;
                    k++;
                }
                if(diasT[i]>mayortemp)
                {
                    mayortemp = diasT[i];
                    Dmayortemp = i;
                }
                if(diasT[i]<menortemp)
                {
                    menortemp = diasT[i];
                    Dmenortemp= i;
                }
            }
            for(int i = 0;i < 6;i++)
            {
                diferencia = diasT[i+1]-diasT[i];
                acumd += diferencia;
            }
            variacion = acumd/6;
            Console.WriteLine("Promedio Semanal => "+promedio);
            Console.Write("Dias por encima del promedio >>>>>> ");
            for(int i=0;i<k;i++)
            {
                Console.Write("Dia "+(quedia[i]+1)+" , ");
            }
            Console.WriteLine("\nDia mas caluroso : Dia "+(Dmayortemp+1));
            Console.WriteLine("Dia mas frio : Dia "+(Dmenortemp+1));
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
            Console.Clear();

        }
    }
}