using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using C;
using CSharp;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y;
            cpp cpp= new cpp();
            CSharp.CSharp cshap = new CSharp.CSharp();
            DateTime startTime;
            TimeSpan runTime;

            Console.Write("Fibonacci?: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Fibonacci Recursivo");
            Console.WriteLine();
            
            for (int k = 0; k < 5; k++)
            { 
                startTime = DateTime.Now;
                x = dll.FIBOREC(ref y);
                runTime = DateTime.Now - startTime;
                Console.WriteLine(String.Format("Fibonacci({0})={1}\tLenguaje={2}\tTiempo={3}",y,x,"Fortran",Convert.ToString(runTime.TotalMilliseconds / 1000)));
                x = 0;

                startTime = DateTime.Now;
                x = cpp.fibonacciRecursivo(y);
                runTime = DateTime.Now - startTime;
                Console.WriteLine(String.Format("Fibonacci({0})={1}\tLenguaje={2}\t\tTiempo={3}", y, x, "C++", Convert.ToString(runTime.TotalMilliseconds / 1000)));
                x = 0;

                startTime = DateTime.Now;
                x = cshap.fibonacciRecursivo(y);
                runTime = DateTime.Now - startTime;
                Console.WriteLine(String.Format("Fibonacci({0})={1}\tLenguaje={2}\t\tTiempo={3}", y, x, "C#", Convert.ToString(runTime.TotalMilliseconds / 1000)));
                x = 0;

                Console.WriteLine();
                y += 1;
            }

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Fibonacci Iterativo");
            Console.WriteLine();
            y -= 5;

            for (int k = 0; k < 5; k++)
            {
                startTime = DateTime.Now;
                x = dll.FIBITE(ref y);
                runTime = DateTime.Now - startTime;
                Console.WriteLine(String.Format("Fibonacci({0})={1}\tLenguaje={2}\tTiempo={3}", y, x, "Fortran", Convert.ToString(runTime.TotalMilliseconds / 1000)));
                x = 0;

                startTime = DateTime.Now;
                x = cpp.fibonacciIterativo(y);
                runTime = DateTime.Now - startTime;
                Console.WriteLine(String.Format("Fibonacci({0})={1}\tLenguaje={2}\t\tTiempo={3}", y, x, "C++", Convert.ToString(runTime.TotalMilliseconds / 1000)));
                x = 0;

                startTime = DateTime.Now;
                x = cshap.fibonacciIterativo(y);
                runTime = DateTime.Now - startTime;
                Console.WriteLine(String.Format("Fibonacci({0})={1}\tLenguaje={2}\t\tTiempo={3}", y, x, "C#", Convert.ToString(runTime.TotalMilliseconds / 1000)));
                x = 0;

                Console.WriteLine();
                y += 1;
            }
            Console.ReadLine();
        }
    }
}
