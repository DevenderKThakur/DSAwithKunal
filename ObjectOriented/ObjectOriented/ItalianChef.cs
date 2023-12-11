using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class ItalianChef : Chef  // Inheritance 
        //Chef is a Super Class and ItalianChef is a sub-class
    {
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes the Pasta");
        }
        public virtual void MakeSpecialDish()  // function override using virtual keyword
        {
            Console.WriteLine("The chef makes Pizaa");
        }
    }
}
