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
            Console.WriteLine("Ingrese su peso en kilogramos:");
            this.peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese su altura en metros:");
            this.altura = Convert.ToDouble(Console.ReadLine());
        }

        public void CalcularIMC()
        {
            if (altura <= 0)
            {
                throw new ArgumentException("La altura debe ser mayor que cero.");
            }

             imc = peso / (altura * altura);
             Console.WriteLine("Su IMC es: " + imc);
        }

        public void ResultadoIMC()
        {
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
        } 
    }
}