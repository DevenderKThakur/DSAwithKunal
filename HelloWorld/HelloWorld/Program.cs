using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            Basic Add 
            Console.WriteLine("Enter the first num ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second num");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1+ num2); 
            */


            Console.WriteLine("Enter the color :");
            String color = Console.ReadLine();

            Console.WriteLine("Enter the second color :");
            String color2 = Console.ReadLine();

            Console.WriteLine("Enter the feeling :");
            String feelings = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine("violets are " + color2);
            Console.WriteLine($"I {feelings} you");

            Console.ReadLine(); 
        }
    }
}
