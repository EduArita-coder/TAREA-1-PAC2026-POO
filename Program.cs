// See https://aka.ms/new-console-template for more information
using TAREA_1_POO.bloque1;
using TAREA_1_POO.bloque2;
using TAREA_1_POO.bloque3;
using TAREA_1_POO.bloque4;
using TAREA_1_POO.bloque5;
int opcion = 0,opcion1 = 0;
do
{
    Console.WriteLine("=======MENU======");
    Console.WriteLine("....OPCIONES.....");
    Console.WriteLine(">[1]. BLOQUE 1");
    Console.WriteLine(">[2]. BLOQUE 2");
    Console.WriteLine(">[3]. BLOQUE 3");
    Console.WriteLine(">[4]. BLOQUE 4");
    Console.WriteLine(">[5]. BLOQUE 5");
    Console.WriteLine(">[6]. SALIR");
    Console.Write(">>>>:");
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
                    CALCULADORAIMC calculadora = new CALCULADORAIMC();// CALCULADORAIMC
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
            break;
        }
        case 2:
            {
            do{
                Console.WriteLine("Elija una opcion :");
                Console.WriteLine("1. CLASIFICACION DE TRIANGULOS");
                Console.WriteLine("2. CALIFICACIONES UNAH");
                Console.WriteLine("3. CALCULADORA DE DESCUENTO");
                Console.WriteLine("4. DETERMINAR SI UN AÑO ES BISIESTO Y CUANTOS DÍAS TIENE UN MES");
                Console.WriteLine("5. VALIDADOR DE FECHA");
                Console.WriteLine("6. CAJERO AUTOMATICO");
                Console.WriteLine("7. REGRESAR AL MENU ANTERIOR");
                opcion1 = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion1)
                {
                    case 1://CLASIFICACION DE TRIANGULOS
                        {
                        TRIANGULOS triangulos = new TRIANGULOS();
                        break;
                        }
                    case 2://CALIFICACIONES UNAH
                        {
                        CALIFICACIONESUNAH calificaciones = new CALIFICACIONESUNAH();
                        break;
                        }   
                    case 3://CALCULADORA DE DESCUENTO
                        {
                        CALCULADORADESC descuento = new CALCULADORADESC();
                        break;
                        }
                    case 4: //DETERMINAR SI UN AÑO ES BISIESTO Y CUANTOS DÍAS TIENE UN MES
                        {
                        AÑOBISIESTO año = new AÑOBISIESTO();
                        break;
                        }
                    case 5://VALIDADOR DE FECHA
                            {
                            VALIDADORDEFECHA fecha = new VALIDADORDEFECHA();
                            }
                            break;
                    case 6://CAJERO AUTOMATICO
                            {
                                CAJEROAUTOMATICO cajero = new CAJEROAUTOMATICO();
                            }
                            break;
                }
                    
            }while(opcion1 != 7);
            break;
        }
    case 3:
        do{
                Console.WriteLine("Elija una opcion :");
                Console.WriteLine("1. TABLA DE MULTIPLICAR EXTENDIDA");
                Console.WriteLine("2. NUMEROS PRIMOS EN RANGO");
                Console.WriteLine("3. GENERACION DE SERIE FIBONACCI");
                Console.WriteLine("4. FACTORIAL O COMBINACIONES");
                Console.WriteLine("5. ADIVINAR NUMERO");
                Console.WriteLine("6. CONTRASEÑA SEGURA VALIDACION");
                Console.WriteLine("7. GENERACION DE FIGURAS CON ASTERISCOS");
                Console.WriteLine("8. CALCULADORA CON MENU");
                Console.WriteLine("9. REGRESAR AL MENU ANTERIOR");
                opcion1 = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion1)
                {
                    case 1://Tabla de multiplicar extendida
                        {
                        TABLADEMULTIPLICAR tabla = new TABLADEMULTIPLICAR();
                        break;
                        }
                    case 2://nos brinda 2 numeros, se averigua que primos hay en ese rango
                        {
                        RANGOPRIMOS primos = new RANGOPRIMOS();
                        break;
                        }   
                    case 3://El usuario nos da un numero para generar cierta cantidad de numeros de la serie de fibonacci
                        {
                        FIBONACCI serie = new FIBONACCI();
                        break;
                        }
                    case 4: //El usuario elige entre calcular factorial o combinatoria de n numeros
                        {
                        FACTORIALYCOMBI facto = new FACTORIALYCOMBI();
                        break;
                        }
                    case 5://El usuario trata de adivinar el numero generado;
                            {
                            ADIVINANZA adivinar = new ADIVINANZA();
                            break;
                            }
                            
                    case 6://Contra Segura o no
                            {
                               CONTRA contrasegura = new CONTRA();
                               break;
                            }
                            
                    case 7://Generacion de figuras con asteriscos
                        {
                            PATRONASTERISCO patron = new PATRONASTERISCO();
                            break;
                        }
                    case 8://Calculadora Funcional que guarda datos anteriores
                        {
                            CALCULADORA calcu = new CALCULADORA();
                            break;
                        }
                }
                    
            }while(opcion1 != 9);
        break;
    case 4:
           {
            do{
                Console.WriteLine("Elija una opcion :");
                Console.WriteLine("1. ESTADISTICAS CALIFICACIONES");
                Console.WriteLine("2. BUSQUEDA Y ORDENAMIENTO");
                Console.WriteLine("3. ROTACION DE ARREGLO");
                Console.WriteLine("4. FRECUENCIA DE ELEMENTOS");
                Console.WriteLine("5. ARREGLO DE TEMPERATURAS");
                Console.WriteLine("6. REGRESAR AL MENU ANTERIOR");
                opcion1 = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion1)
                {
                    case 1://ESTADISTICAS DE CALIFICACIONES
                        {
                        ESTADCALIFICACIONES notas = new ESTADCALIFICACIONES();
                        break;
                        }
                    case 2://BUSQUEDA LINEAL, SEGUNDO MAYOR Y ORDENAMIENTO POR PARES
                        {
                        BUSQUEDA buscar = new BUSQUEDA();
                        break;
                        }   
                    case 3://ROTACION ARREGLO
                        {
                        ROTACION rotar = new ROTACION();
                        break;
                        }
                    case 4: 
                        {
                        FRECUENCIA frecuencia = new FRECUENCIA();
                        break;
                        }
                    case 5://TEMPERATURAS ARREGLO
                            {
                        ARREGLOTEMPS temps = new ARREGLOTEMPS();
                            }
                            break;
                    default:
                            {
                                Console.WriteLine("COMANDO NO VALIDO/ OPCION FUERA DEL RANGO");
                                break;
                            }
                }    
                }while(opcion1 != 6);
                break;
            }
    case 5:
        {
            do  {
                Console.WriteLine("Elije una opcion:");
                Console.WriteLine("1.Matriz de notas por parcial");
                Console.WriteLine("2.Juego de Gato (tic-tac-toe)");
                Console.WriteLine("3.Inventario simple");
                Console.WriteLine("4.Regresar");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                            {
                                MATRIZNOTAS matriz = new MATRIZNOTAS();
                                break;
                            }
                    case 2:
                            {
                                JUEGOGATO tictactoe = new JUEGOGATO();
                                break;
                            }
                    case 3:
                            {
                                INVENTARIO inventario = new INVENTARIO();
                                break;
                            }
                        
                    default:
                    break;
                }
                }while(opcion != 4);
        break;
        }
    case 6:
        {
        break;
        }
    default:
        {
            Console.WriteLine("COMANDO NO VALIDO/ OPCION FUERA DEL RANGO");
              break;
        }
    }
}while(opcion !=  6);


