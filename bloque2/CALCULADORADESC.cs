using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque2
{
    
    public class CALCULADORADESC
    {
        double montoCompra, descuento, montoFinal;
        public CALCULADORADESC()
        {
            Console.WriteLine("Ingrese el monto de su compra : ");
            montoCompra = double.Parse(Console.ReadLine());
            if (montoCompra >= 500 && montoCompra < 1000)
            {
                descuento = montoCompra * 0.05;
                montoFinal = montoCompra - descuento;
            }
            else
            {
                if (montoCompra >= 1000 && montoCompra < 2499)
                {
                    descuento = montoCompra * 0.10;
                    montoFinal = montoCompra - descuento;
                }
                else
                {
                    if (montoCompra >= 2500)
                    {
                        descuento = montoCompra * 0.15;
                        montoFinal = montoCompra - descuento;
                    }
                    else
                        {
                            Console.WriteLine("No se aplica descuento para compras menores a 500");
                            montoFinal = montoCompra;
                        }
                }
            }
            Console.WriteLine("El monto de su compra es: " + montoCompra);
            Console.WriteLine("El descuento aplicado es: " + descuento);
            Console.WriteLine("El monto final a pagar es: " + montoFinal);
            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para regresar al menu anterior");
            Console.ReadKey();
            Console.Clear();
        }
      
    }
}