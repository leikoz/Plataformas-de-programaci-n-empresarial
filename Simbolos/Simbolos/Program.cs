using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simbolos
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] Simbolos = { '#', '$', '!', '?', '%' };

            int nIteraciones;

            int nSimbolos;

            int numSymbol;

            char Symbol = 'a';

            int refe = 0, aux = 0, contador = 0;

            Console.WriteLine("Ingrese el número de iteraciones");
            nIteraciones = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de simbolos que se utilizarán\n (Max 5)");
            nSimbolos = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero del simbolo que desea encontrar");
            numSymbol = Int32.Parse(Console.ReadLine());


            if (nIteraciones * nSimbolos < numSymbol)
                Console.WriteLine("No es posible hallar el número");

            else
            {
                for (int i = 0; i < nIteraciones; i++)
                {
                    
                    for (int j = i; j >= 0; j--)
                    {
                        Console.Write(".");
                    }

                    aux = refe;

                    

                    for (int k = 0; k < nSimbolos; k++)
                    {
                        if (contador == numSymbol - 1)
                            Symbol = Simbolos[aux];

                        Console.Write(Simbolos[aux]);
                        aux++; contador++;                        

                        if (aux == 5)
                            aux = 0;

                    }
                    Console.WriteLine();
                    refe++;

                    if (refe == 5)
                        refe = 0;
                    
                }

                Console.WriteLine("El Simbolo " + numSymbol + " es: " + Symbol);
            }


        }
    }
}
