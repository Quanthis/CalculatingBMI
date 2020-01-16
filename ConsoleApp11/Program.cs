using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Tell me your mass");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tell me your height");
            y = Convert.ToDouble(Console.ReadLine());
            z = (x / (y * y));
            Console.Write("Your BMI is: ");
            Console.Write(z);
            Console.ReadKey();
        }
    }
}
