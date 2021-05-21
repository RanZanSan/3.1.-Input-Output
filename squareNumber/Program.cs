using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int squareNumber = number * number;

            Console.WriteLine(squareNumber);
            Console.ReadKey();
        }
    }
}