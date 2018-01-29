using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Complex c1 = new Complex(1, 4);
            Complex c2 = new Complex(2, 5);

            Complex myresult = c1 + c2;

            Console.WriteLine("Сумма комплексных чисел равна: " + myresult);
        }
    }
}
