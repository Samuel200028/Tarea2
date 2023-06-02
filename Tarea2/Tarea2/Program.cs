using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long numVal = -1;
            bool volver = true;
            Stopwatch stopWatch = new Stopwatch();
            

            while (volver) { 
                    Console.Write("Ingresa un numero: ");
                string num1 = Console.ReadLine();
                try
                {
                    numVal = Convert.ToInt64(num1);
                    if (numVal > -1)
                    {
                        Console.WriteLine("El valor ingresado es: {0}", numVal);
                    }
                    else
                    {
                        Console.WriteLine("No se permiten numeros negativos");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("No es un digito.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("El numero exede formato Int64.");
                }

                int cont = 0, auxcont = 0;
                stopWatch.Start();
                while (numVal != 1)
                {
                    if(numVal % 2 == 0)
                    {
                        cont++;
                        if(cont > auxcont)
                        {
                            auxcont = cont;
                        }
                    }
                    else
                    {
                        cont = 0;
                    }
                    numVal = numVal / 2;
                }
                Console.WriteLine(auxcont);
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                Console.WriteLine("RunTime " + elapsedTime);




                Console.Write("Continuar? Y/N: ");
                string si = Console.ReadLine();
                if (si?.ToUpper() != "Y")
                {
                    volver = false;
                }

            }
        }
    }
}
