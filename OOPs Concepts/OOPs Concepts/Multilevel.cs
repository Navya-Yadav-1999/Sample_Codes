using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    public class Multilevel
    {
        public void adding()
        {
           Console.WriteLine("a+b");
        }
    }
    public class count: Multilevel
    {
        public void subtract()
        {
            Console.WriteLine("a-b");
        }
    }
    public class counting : count
    {
        public void multiply()
        {
           Console.WriteLine("a*b");
        }
    }
}
