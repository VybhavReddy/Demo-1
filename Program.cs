using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 integers");
            int a= Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition value: {0}", a+b);
            Console.WriteLine("subtraction value: {0}", a - b);
            Console.WriteLine("Multiplication value: {0}", a * b);
            Console.WriteLine("Division value: {0}", a / b);
            Console.Read();
        }
    }
}
