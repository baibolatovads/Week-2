using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Smallest_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitter = { ' ', '.' };
            string line = File.ReadAllText(path: @"C:\Users\User_PC\Documents\PP2\Student\Week 2\\Minmax.txt");
            //string[] numbers = line.Split(splitter);
            string[] numbers = File.ReadAllLines(path: @"C:\Users\User_PC\Documents\PP2\Student\Week 2\\Minmax.txt");
            int n = numbers.Length;
            var primes = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int t = int.Parse(numbers[i]);
                if (Class1.IsPrime(t))
                {
                    primes.Add(t);
                }
            }
            File.WriteAllText(@"C:\Users\User_PC\Documents\PP2\Student\Week 2\\output.txt", primes.Min().ToString());
        } 
    }
}
