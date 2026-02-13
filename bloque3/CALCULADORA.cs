using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque3
{
    public class CALCULADORA
    {
        public CALCULADORA()
        {
            int opc;
            double ans = 0,raiz,a,b,c;
            do{
                                    Console.Clear();
            Console.WriteLine("Que desea realizar a continuacion>>>>?");
            Console.WriteLine("los calculos utilizados anteriormente se guardan para seguir usando otras opciones");
            Console.WriteLine("1.Sumar");
            Console.WriteLine("2.Restar");
            Console.WriteLine("3.multiplicar");
            Console.WriteLine("4.dividr");
            Console.WriteLine("5.calcular potencia");
            Console.WriteLine("6.Raiz cuadrada");
            Console.WriteLine("7.calculo de porcentaje");
            Console.WriteLine("8.borrar datos anteriores");
            Console.WriteLine("9.salir");
            opc = int.Parse(Console.ReadLine());
            if(opc == 8)
                {
                    ans = 0;
                }
            switch(opc)
            {
                
                case 1 :
                        {
                            if(ans == 0)
                            {
                                Console.WriteLine("Ingrese el primer numero a sumar");
                                a = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el segundo numero a sumar");
                                b = int.Parse(Console.ReadLine());
                                ans = a + b;
                                
                            }
                            else
                            {
                                Console.WriteLine("Ingrese el valor a sumar:");
                                c = int.Parse(Console.ReadLine());
                                ans += c;
                            }
                            break;
                        }
                case 2 : 
                        {
                        if(ans == 0)
                            {
                                Console.WriteLine("Ingrese el primer numero a restar");
                                a = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el segundo numero a restar");
                                b = int.Parse(Console.ReadLine());
                                ans = a - b;
                                
                            }
                            else
                            {
                                Console.WriteLine("Ingrese el valor por el cual va a restar:");
                                c = int.Parse(Console.ReadLine());
                                ans -= c;
                            }
                            break;
                        }
                case 3 :
                        {
                             if(ans == 0)
                            {
                                Console.WriteLine("Ingrese el primer numero a multiplicar");
                                a = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el segundo numero a multiplicar");
                                b = int.Parse(Console.ReadLine());
                                ans = a * b;
                                
                            }
                            else
                            {
                                Console.WriteLine("Ingrese el valor a multiplicar:");
                                c = int.Parse(Console.ReadLine());
                                ans *= c;
                            }
                            break;
                        }
                case 4:
                        {
                            if(ans == 0)
                            {
                                do{
                                Console.WriteLine("Ingrese el primer numero a dividir");
                                a = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el segundo numero a dividir");
                                b = int.Parse(Console.ReadLine());
                                if(b== 0)
                                    {
                                        Console.WriteLine("No se permite dividir entre 0, intente de nuevo(pulse enter..)");
                                        Console.ReadKey();
                                    }
                                    Console.Clear();
                                }while(b == 0);
                                ans = a / b;
                                
                            }
                            else
                            {
                                do{
                                Console.WriteLine("Ingrese el valor a dividr:");
                                c = int.Parse(Console.ReadLine());
                                if(c == 0)
                                    {
                                        Console.WriteLine("No se permite dividir entre 0, intente de nuevo(pulse enter..)");
                                        Console.ReadKey();
                                    }
                                    Console.Clear();
                                }while(c == 0);
                                ans /= c;
                            }
                            break;  
                        }
                case 5 :
                        {
                            if(ans == 0)
                            {
                                Console.WriteLine("Ingrese el numero que va a elevar");
                                a = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese a que potencia lo elevara");
                                b = int.Parse(Console.ReadLine());
                                ans = Math.Pow(a,b);
                                
                            }
                            else
                            {
                                Console.WriteLine("Ingrese el valor al que elevara el resulado anterior:");
                                c = int.Parse(Console.ReadLine());
                                ans = Math.Pow(ans,c);
                            }
                            break;
                        }
                case 6:
                        {
                            if(ans == 0)
                            {
                                Console.WriteLine("Ingrese el valor a calcular la raiz");
                                raiz = int.Parse(Console.ReadLine());
                                ans = Math.Sqrt(raiz);
                                
                            }
                            else
                            {
                                Console.WriteLine("calculando la raiz cuadrada de : "+ ans);
                                ans = Math.Sqrt(ans);
                            }
                            break;
                        }
                case 7:
                    {
                        if(ans == 0)
                            {
                                Console.WriteLine("Ingrese el numero que desea calcularle el porcentaje");
                                a = int.Parse(Console.ReadLine());
                                Console.WriteLine("Que porcentaje desea calcular");
                                b = int.Parse(Console.ReadLine());
                                double prctj = b/100;
                                ans = a*(prctj);
                                
                            }
                            else
                            {
                                Console.WriteLine("Ingrese el porcentaje que desea calcular:");
                                c = int.Parse(Console.ReadLine());
                                double prctj = c/100;
                                ans = ans*(prctj);
                            }
                            break;
                    }
                }
                if(opc < 8)
                {
                Console.WriteLine($"Resultado = {ans:F2}");
                Console.WriteLine("\nPresione enter para limpiar pantalla");
                Console.ReadKey();
                Console.Clear();
                }
                if(opc == 9)
                {
                    Console.Clear();
                }
            }while(opc != 9);
            

        }
    }
}