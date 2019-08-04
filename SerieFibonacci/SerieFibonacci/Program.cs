using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            int Anterior = 1, Total, aux;

            Console.WriteLine("Ingrese el número de la serie de fibonacci que desea");
            n = Int32.Parse(Console.ReadLine());




            if (n == 1 || n == 2)
                Console.WriteLine("1");

            Total = 1 + Anterior;   //Caso Base

            for(int i = 2; i < n; i++)
            {
                aux = Total;
                Total += Anterior;
                Anterior = aux;
            }

            Console.WriteLine(Total);

        }
    }
}
