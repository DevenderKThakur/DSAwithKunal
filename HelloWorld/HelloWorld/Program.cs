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

            /*
            Console.WriteLine("Enter the color :");
            String color = Console.ReadLine();

            Console.WriteLine("Enter the second color :");
            String color2 = Console.ReadLine();

            Console.WriteLine("Enter the feeling :");
            String feelings = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine("violets are " + color2);
            Console.WriteLine($"I {feelings} you"); */

            /* Array 
            int[] arr = { 1, 2, 3, };
            Console.WriteLine(arr[2]);
             */

            /* Method calling 
            String name = "Devender";
            greetings(name);
             */

 
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine()); 
            int op = Convert.ToInt32(Console.ReadLine());
            int result = Calculator(num1, num2, op);
            Console.WriteLine(result);


            Console.ReadLine(); 
        }
    }
        static int addSum (int a , int b)
        {
            return a + b;
        }
    
        static void greetings(String str)
        {
            Console.WriteLine($"Hello {str}");
        }
    
        static int Calculator(int a , int b , int operation)
        {
            if (operation == 1)
            {
                return a + b;
            }
            else if (operation == 2)
            {
                return a - b;
            }
            else if (operation == 3)
            {
                return a * b;
            }
            else if (operation == 4)
            {
                return a / b;
            }
            return -1;
        }
      }
    }
}
