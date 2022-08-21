using System;

namespace Constructor2
{

      class dog
    {

       public int legs;
       public int eyes;
       public String name;
       public String breed; 
        public dog (int legs, int eyes)
        {
            this.legs = legs;
            this.eyes = eyes;

        }
        public dog(int legs , int eyes, String name)
        {
            this.legs = legs;
            this.eyes = eyes; 
            this.name = name;
            breed = "Jerman shephared";


        }
    }
    class constructor2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            dog oobj = new dog(34,56);
            dog obj2 = new dog(34, 56, "kks");
            Console.WriteLine(" " + oobj.legs + " " + oobj.eyes + " " + oobj.name + " " + obj2.breed);

        }
    }
}
