using System;

namespace Constructor
{

    class Bike
    {
       public int tyres;
       public  String name;
        
        public   Bike()
        {
            tyres = 2;
            name = "Apache";
        }
    }
    public class Program
    {

      public  Program()
        {
            Console.WriteLine("Hello cons");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program obj1 = new Program();

            Bike obj2 = new Bike();
            Console.WriteLine("The bike has " + obj2.tyres + " tyres and The bike name is " + obj2.name);



        }
    }
}
