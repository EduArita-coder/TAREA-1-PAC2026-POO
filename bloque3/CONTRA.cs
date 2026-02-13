using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace TAREA_1_POO.bloque3
{
    public class CONTRA
    {
        string password;
        bool esSegura = true ;
        public CONTRA()
        {
            Console.WriteLine("Ingrese una contraseña para la validacion (debe tener minimo 8 caracteres,1 mayuscula,1 minuscula,un numero y un caracter especial)");
            password = Console.ReadLine();

            
            if(esSegura == (password.Length>8))
            {
                if(esSegura == password.Any(char.IsUpper) )
                {
                    if(esSegura == password.Any(char.IsLower))
                    {
                        if(esSegura == password.Any(char.IsDigit))
                        {
                            Console.WriteLine("Su contraseña cumple con todos los requisitos");
                        }
                        else
                        {
                             Console.WriteLine("La contraseña no contiene un digito");
                        }
                    }
                    else
                    {
                        Console.WriteLine("La contraseña no contiene una minuscula");
                    }
                }
                else
                {
                    Console.WriteLine("La contraseña no contiene una mayuscula");
                }
            }
            else
            {  
                Console.WriteLine("La contraseña debe tener minimo 8 caracteres");
            }
             Console.WriteLine("\nPresione cualquier tecla para continuar");
             Console.ReadKey(true);
             Console.Clear();
        }
    }
}