using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class Chef
    {
        public void MakeChickn()
        {
            Console.WriteLine("The chef makes the chicken ");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The chef makes the Saland");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef make bbq-ribs");
        }
    }
}
