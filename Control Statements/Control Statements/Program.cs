// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
public class test
{
    private static int i=5;
    public static void Main(string[] args)
    {
        if (i > 0)
        {
            Console.WriteLine("Number {0} is positive:", i);
        }
        else if(i<0)
        {
            Console.WriteLine("Number {0} is negative", i);
        }
        else
        {
            Console.WriteLine("Number {0} is equal", i);
        }
    }
}
