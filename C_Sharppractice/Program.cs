using System;

namespace C_Sharppractice
{

    class cat
    {
      public   int legs;
       public String name;


       public void walk()
        {
            Console.WriteLine(name + " is walking");
            
        }

       public void eat()
        {
            Console.WriteLine(name + " is eating");
        }


        
    }
    class Program
    {

        /* static int addproduct(int x , int y)
        {
            int sum = x + y;
            return sum;

        }

        static void sayhey()
        {
            Console.WriteLine("Hello Anushka");
        }
        
        static int addproduct(int x, int y,int z )
        {
            int sum = x + y + z;
            return sum;
        } */

        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");

            // Console.WriteLine(addproduct(34, 56));

            // sayhey();

            // Console.WriteLine(addproduct(23, 45, 56));


            // object_classes obj1 = new object_classes();

            /* obj1.legs = 45;
             obj1.name = "Satyam";

             Console.WriteLine("The object has "  + obj1.legs);
             Console.WriteLine("The object name has " + obj1.name);

             obj1.walk();
             obj1.sleep()*/



            cat obj1 = new cat();

            obj1.legs = 4;
            obj1.name = "Oggy";

            Console.WriteLine("The cat has " + obj1.legs + " legs and his name is " + obj1.name);
            obj1.walk();
            obj1.eat();

        }
    }
}
