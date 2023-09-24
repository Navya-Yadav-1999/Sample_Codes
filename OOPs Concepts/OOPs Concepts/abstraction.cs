using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    internal class abstraction
    {
        public void display()
        {
            Console.WriteLine("Display the content:");
        }
    }
     class show : abstraction
    {
        public void print()
        {
            Console.WriteLine("Print the statement:");
        }
    }
}
