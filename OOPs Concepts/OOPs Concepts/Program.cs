// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace OOPs_Concepts;

using System;
using System.Net;
using OOPsConcept;
using OOPsConsepts;

class Program
{
    public static void Main(string[] args)
    {
      pencil p=new pencil();
        Console.WriteLine("Singlelevel:");
        p.add();
        p.sub();
       
        counting c= new counting();
        Console.WriteLine("Multilevel:");
        Console.WriteLine("adding:" +(2+3));
        Console.WriteLine("subtract:"+(2-4));
        Console.WriteLine("multiply:"+(2*2));
       
        Console.WriteLine("OverLoading:");
        overloading o= new overloading();
        Console.WriteLine(6 +7);
        Console.WriteLine(4+7+8);

        Console.WriteLine("Overriding:");
        Demo d= new Demo();
        d.addd();
        d.mul();

        Console.WriteLine("Abstraction:");
        show s= new show();
        s.display();
        s.print();

        Interface1 ins;
        ins = new Rectangle();
        ins.draw();
        ins = new Circle();
        ins.draw();

        Encapsulation student = new Encapsulation();
        // Setters
        student.ID = "5731";
        student.Name = "Revathi";
        student.Email = "revathi@gmail.com";
        // getters

        Console.WriteLine("Encapsulation:");
        Console.WriteLine("ID = " + student.ID);
        Console.WriteLine("Name = " + student.Name);
        Console.WriteLine("Email = " + student.Email);
    }
}
