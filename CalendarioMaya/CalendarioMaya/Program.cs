using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioMaya
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] VectorNombres = {"","imix","ik","akbal","kan","chicchan","cimi","manik","lamat","muluk","ok","chuen","eb","ben","ix","mem","cib","caban","eznab","canac","ahau"};

            int [] VectorNumeros = new int [260];

            int x = 1;
            string fecha;
            string[] Vfecha;
            int dias, Nmes, Tannos, n = 0;
            string MesT;
            int diaT;

            for (int i = 1; i < 260; i++) //Llenamos el vector con los numeros 1 - 13 
            {
                if (x > 13)
                    x = 1;

                VectorNumeros[i] = x;
                x++;
            }

            Console.WriteLine("Ingrese la fecha \n");
            fecha = Console.ReadLine();
            Vfecha = fecha.Split(' ');

            Nmes = HelpMes(Vfecha[1]);

            if (Nmes == -1)
                Console.WriteLine("El mes no se encontró");
            else
            {
                dias = Int32.Parse(Vfecha[2]) * 365 + Nmes + (Int32.Parse(Vfecha[0]) + 1);

                Tannos = dias / 260; 

                n = dias - Tannos * 260;

                diaT = VectorNumeros[n];

                while (n > 20)
                    n -= 20;

                MesT = VectorNombres[n];

                Console.WriteLine(diaT + " " + MesT + " " + Tannos);
            }
        

        }

        static int HelpMes(string mes) //Convierte el mes en días 
        {
            int Nmes = 0;

            switch (mes)
            {
                case "pop":
                    Nmes = 0;
                    break;
                case "no":
                    Nmes = 20;
                    break;
                case "zip":
                    Nmes = 40;
                    break;
                case "zotz":
                    Nmes = 60;
                    break;
                case "tzec":
                    Nmes = 80;
                    break;
                case "xul":
                    Nmes = 100;
                    break;
                case "yoxkin":
                    Nmes = 120;
                    break;
                case "mol":
                    Nmes = 140;
                    break;
                case "chen":
                    Nmes = 160;
                    break;
                case "yax":
                    Nmes = 180;
                    break;
                case "zac":
                    Nmes = 200;
                    break;
                case "ceh":
                    Nmes = 220;
                    break;
                case "mac":
                    Nmes = 240;
                    break;
                case "kankin":
                    Nmes = 260;
                    break;
                case "muan":
                    Nmes = 280;
                    break;
                case "pax":
                    Nmes = 300;
                    break;
                case "koyab":
                    Nmes = 320;
                    break;
                case "cumhu":
                    Nmes = 340;
                    break;
                case "uayet":
                    Nmes = 360;
                    break;
                default:
                    Nmes = -1;
                    break;                
            }
            return Nmes;
        }
    }
}
