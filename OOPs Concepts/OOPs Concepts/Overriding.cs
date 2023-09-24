using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    public class Overriding
    {
         public void addd()
        {
            Console.WriteLine("a+b");
        }
    }
    public class test : Overriding
    {
        public void addd()
        {
            Console.WriteLine("a-b");
        }
    }
    public class Demo : test
    {
        public void mul()
        {
            Console.WriteLine("a*b");
        }
    }
    

}
