using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConsepts
{
    public interface Interface1
    {
        void draw();

    }
    public class Rectangle : Interface1
    {

        public void draw()
        {
            Console.WriteLine("Interface:" + "drawing rectangle...");
        }
    }
    public class Circle : Interface1
    {
        public void draw()
        {
            Console.WriteLine("drawing circle...");
        }

    }

}

