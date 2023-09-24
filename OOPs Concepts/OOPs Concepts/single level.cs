using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{

    public class singlelevel
    {
        public void add()
        {
            Console.WriteLine("a+b");
        }
    }
        public class pencil : singlelevel
        {
            public void sub()
            {
                Console.WriteLine("a-b");
            }
        }
}

