using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque5
{
    public class JUEGOGATO
    {
        public JUEGOGATO()
        {
            char[,] tablero = new char[3,3];
            char jugador = 'X';
            bool ganador = false;
            int movimientos = 0;
            int fila, columna;
            string opcion;

            do
            {
                for(int i = 0; i < 3; i++)
                    for(int j = 0; j < 3; j++)
                        tablero[i,j] = ' ';

                jugador = 'X';
                ganador = false;
                movimientos = 0;

                while(!ganador && movimientos < 9)
                {
                    Console.Clear();
                    Console.WriteLine("   0   1   2");
                    for(int i = 0; i < 3; i++)
                    {
                        Console.Write(i + "  ");
                        for(int j = 0; j < 3; j++)
                        {
                            Console.Write(tablero[i,j]);
                            if(j < 2) Console.Write(" | ");
                        }
                        Console.WriteLine();
                        if(i < 2) Console.WriteLine("  ---+---+---");
                    }

                    Console.WriteLine("\nTurno jugador: " + jugador);
                    Console.Write("Fila: ");
                    fila = int.Parse(Console.ReadLine());
                    Console.Write("Columna: ");
                    columna = int.Parse(Console.ReadLine());

                    if(fila >=0 && fila <3 && columna >=0 && columna <3 && tablero[fila,columna] == ' ')
                    {
                        tablero[fila,columna] = jugador;
                        movimientos++;

                        if(
                            (tablero[0,0]==jugador && tablero[0,1]==jugador && tablero[0,2]==jugador) ||
                            (tablero[1,0]==jugador && tablero[1,1]==jugador && tablero[1,2]==jugador) ||
                            (tablero[2,0]==jugador && tablero[2,1]==jugador && tablero[2,2]==jugador) ||
                            (tablero[0,0]==jugador && tablero[1,0]==jugador && tablero[2,0]==jugador) ||
                            (tablero[0,1]==jugador && tablero[1,1]==jugador && tablero[2,1]==jugador) ||
                            (tablero[0,2]==jugador && tablero[1,2]==jugador && tablero[2,2]==jugador) ||
                            (tablero[0,0]==jugador && tablero[1,1]==jugador && tablero[2,2]==jugador) ||
                            (tablero[0,2]==jugador && tablero[1,1]==jugador && tablero[2,0]==jugador)
                          )
                        {
                            ganador = true;
                            Console.Clear();
                            Console.WriteLine("Gana el jugador: " + jugador);
                        }
                        else
                        {
                            jugador = (jugador == 'X') ? 'O' : 'X';
                        }
                    }
                }

                if(!ganador)
                {
                    Console.Clear();
                    Console.WriteLine("Empate.");
                }

                Console.WriteLine("Desea reiniciar? (S/N)");
                opcion = Console.ReadLine().ToUpper();
                if (opcion == "N")
                {
                    Console.Clear();
                }

            } while(opcion == "S");
        }
    }
}
