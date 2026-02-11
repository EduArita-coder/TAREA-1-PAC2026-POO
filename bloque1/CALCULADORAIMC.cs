using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque1
{
        
    public class CALCULADORAIMC
    {    public double peso, altura, imc;

        public CALCULADORAIMC()
        {
            do{
            Console.WriteLine("Ingrese su peso en kilogramos:");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese su altura en metros:");
            altura = Convert.ToDouble(Console.ReadLine());

            if (altura <= 0 || peso <= 0)
            {
                throw new ArgumentException("Datos invalidos. El peso y la altura deben ser mayores que cero.");
            }
            }while(altura <= 0 || peso <= 0);

             imc = peso / (altura * altura);
             Console.WriteLine("Su IMC es: " + imc);

                if (imc < 18.5)
                {
                Console.WriteLine("Bajo peso");
                }
                else if (imc >= 18.5 && imc < 24.9)
                {
                Console.WriteLine("Peso normal");
                }
                else if (imc >= 25 && imc < 29.9)
                {
                Console.WriteLine("Sobrepeso");
                }
            else
            {
                Console.WriteLine("Obesidad");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}