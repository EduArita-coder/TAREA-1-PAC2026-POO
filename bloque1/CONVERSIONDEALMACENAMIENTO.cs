using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque1
{
    public class CONVERSIONDEALMACENAMIENTO
    {
        int opcion;
        public CONVERSIONDEALMACENAMIENTO()
        {
            do{
            Console.WriteLine("Que accion desea realizar : ");
            Console.WriteLine("1. Convertir de Bytes a KB");
            Console.WriteLine("2. Convertir de KB a MB");
            Console.WriteLine("3. Convertir de MB a GB");
            Console.WriteLine("4. Convertir de GB a TB");
            Console.WriteLine("5. Convertir de TB a MB");
            Console.WriteLine("6. Convertir de MB a KB");
            Console.WriteLine("7. Convertir de KB a Bytes");
            Console.WriteLine("8. Regresar al menu anterior");
            opcion = int.Parse(Console.ReadLine());
            } while (opcion < 1 || opcion > 8);
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese la cantidad de Bytes : ");
                    double bytes = double.Parse(Console.ReadLine());
                    double kb = bytes / 1024;
                    Console.WriteLine(bytes + " Bytes son " + kb + " KB");
                    break;
                case 2:
                    Console.WriteLine("Ingrese la cantidad de KB : ");
                    double kb1 = double.Parse(Console.ReadLine());
                    double mb = kb1 / 1024;
                    Console.WriteLine(kb1 + " KB son " + mb + " MB");
                    break;
                case 3:
                    Console.WriteLine("Ingrese la cantidad de MB : ");
                    double mb1 = double.Parse(Console.ReadLine());
                    double gb = mb1 / 1024;
                    Console.WriteLine(mb1 + " MB son " + gb + " GB");
                    break;
                case 4:
                    Console.WriteLine("Ingrese la cantidad de GB : ");
                    double gb1 = double.Parse(Console.ReadLine());
                    double tb = gb1 / 1024;
                    Console.WriteLine(gb1 + " GB son " + tb + " TB");
                    break;
                case 5:
                    Console.WriteLine("Ingrese la cantidad de TB : ");
                    double tb1 = double.Parse(Console.ReadLine());
                    double mb2 = tb1 * 1024;
                    Console.WriteLine(tb1 + " TB son " + mb2 + " MB");
                    break;
                case 6:
                    Console.WriteLine("Ingrese la cantidad de MB : ");
                    double mb3 = double.Parse(Console.ReadLine());
                    double kb2 = mb3 * 1024;
                    Console.WriteLine(mb3 + " MB son " + kb2 + " KB");
                    break;
                case 7:
                    Console.WriteLine("Ingrese la cantidad de KB : ");
                    double kb3 = double.Parse(Console.ReadLine());
                    double bytes2 = kb3 * 1024;
                    Console.WriteLine(kb3 + " KB son " + bytes2 + " Bytes");
                    break;
                case 8:
                    Console.Clear();
                    break;

            }
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

        }
    }
}