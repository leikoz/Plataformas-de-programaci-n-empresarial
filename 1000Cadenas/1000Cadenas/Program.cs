using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int lenght;

            for (int i = 0; i < 1000; i++)
            {
                lenght = r.Next(2, 8);
                string cadena = "";
                int contadorC = 0;
                int contadorV = 0;
                string[] vocalRnd = { "a", "e", "i", "o", "u" };

                for (int j = 0; j < lenght; j++) //97 - 122 : 97 101 105 111 117
                {
                    char letra = (char)r.Next(97, 122);

                    if (letra != 97 && letra != 101 && letra != 105 && letra != 111 && letra != 117)
                        contadorC++;
                    else
                        contadorV++;

                    cadena += letra;

                    if (contadorC > 4 && contadorV == 0)
                    {
                        cadena += vocalRnd[r.Next(0, 4)];
                    }

                }

                Console.WriteLine(cadena);
            }
        }
    }
}
