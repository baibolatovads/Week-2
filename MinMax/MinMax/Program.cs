using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = File.ReadLines(path: @"C:\Users\User_PC\Documents\PP2\Student\Week 2\\Minmax.txt").Select(s => Convert.ToDecimal(s, CultureInfo.InvariantCulture)).ToList();
            var max = numbers.Max();
            var min = numbers.Min();
            Console.WriteLine(min.ToString());
            Console.WriteLine(max.ToString());
        }
    }
}
