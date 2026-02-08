// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Text;
using System.Linq.Expressions;
using TAREA_1_POO.bloque1;
using System.Net.Http.Headers;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
int opcion = 0,opcion1 = 0;
do
{
    Console.WriteLine("MENU:");
    Console.WriteLine("Elija una opcion :");
    Console.WriteLine("1. BLOQUE 1");
    Console.WriteLine("2. BLOQUE 2");
    Console.WriteLine("3. BLOQUE 3");
    Console.WriteLine("4. BLOQUE 4");
    Console.WriteLine("5. BLOQUE 5");
    Console.WriteLine("6. SALIR");
    opcion = int.Parse(Console.ReadLine());
    Console.Clear();
    switch (opcion)
{
    case 1:
        {
            bool salir = false;
            do{
                Console.WriteLine("Elija una opcion :");
                Console.WriteLine("1. CALCULADORA IMC");
                Console.WriteLine("2. CONVERSION DE TEMPERATURA");
                Console.WriteLine("3. DESGLOSE DE BILLETES");
                Console.WriteLine("4. CALCULADORA PRESTAMO SIMPLE");
                Console.WriteLine("5. TIEMPO TRANSCURRIDO");
                Console.WriteLine("6. AREA Y PERIMETRO");
                Console.WriteLine("7. CONVERSION DE UNIDADES DE ALMACENAMIENTO ");
                Console.WriteLine("8. CALCULADORA DE SALARIO MENSUAL");
                Console.WriteLine("9. REGRESAR AL MENU ANTERIOR");
                opcion1 = int.Parse(Console.ReadLine());
                Console.Clear();
              switch (opcion1)
                {
                case 1://CALCULADORA IMC
                    CALCULADORAIMC calculadora = new CALCULADORAIMC();//se crea un objeto de la clase CALCULADORAIMC para poder usar sus metodos
                    calculadora.CalcularIMC();
                    calculadora.ResultadoIMC();
                    break;
                case 2://CONVERSION DE TEMPERATURA
                    CONVERTIRTEMP convertir = new CONVERTIRTEMP();
                    break;
                case 3://DESGLOSE DE BILLETES
                    BILLETES billetes = new BILLETES();
                    break;
                case 4://CALCULADORA PRESTAMO SIMPLE
                    PRESTAMOSIMPLE prestamo = new PRESTAMOSIMPLE();
                    break;
                case 5://TIEMPO TRANSCURRIDO
                    TIEMPOTRANSCURRIDO tiempo = new TIEMPOTRANSCURRIDO();
                    break;
                case 6://AREA Y PERIMETRO
                    AREA_Y_PERIMETRO area = new AREA_Y_PERIMETRO();
                    break; 
                case 7://CONVERSION DE UNIDADES DE ALMACENAMIENTO
                    CONVERSIONDEALMACENAMIENTO conversion = new CONVERSIONDEALMACENAMIENTO();
                    break;  
                case 8://CALCULADORA DE SALARIO MENSUAL
                    SALARIOSEMANAL salario = new SALARIOSEMANAL();
                    break;
                case 9://SALIR
                    Console.Clear();
                    salir = true;
                    break;
                }
    
            }while(!salir);
        }
        break;
    case 2:
        Console.WriteLine("BLOQUE 2");
        break;
    case 3:
        Console.WriteLine("BLOQUE 3");
        break;
    case 4:
        Console.WriteLine("BLOQUE 4");
        break;
    case 5:
        Console.WriteLine("BLOQUE 5");
        break;
    case 6:

        break;
    }
}while(opcion !=  6);


