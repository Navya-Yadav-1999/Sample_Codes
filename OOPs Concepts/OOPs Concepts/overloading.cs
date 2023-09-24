using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    internal class overloading
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void add(int a, int b, int c)
        {
            Console.WriteLine(a+b+c);
        }

    } 
}
