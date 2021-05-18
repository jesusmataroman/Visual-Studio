using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaciondeConsola5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int num1 = 5;
            int num2 = 6;
            double num3 = 2.57;
            double suma;
            suma = num1 + (-num2) + num3;

            Console.WriteLine(suma);
            String val1 = Console.ReadLine();
            Console.WriteLine("El valor introducido es:" + val1);
            int valint = Convert.ToInt32(val1);

            Console.ReadKey();
        }
    }
}
