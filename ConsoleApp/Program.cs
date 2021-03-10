using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 10;
            //Console.WriteLine("Hello World! "+i);
            TestAdd();

        }

        static void TestAdd()
        {
  
            int a;
            int b;
            Console.WriteLine("Enter value of a: ");

           a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter value of b: ");

            // Converted string to int 
            b = Convert.ToInt32(Console.ReadLine());

            
                Console.WriteLine("addition of a and b is:" +(a+b));
     

        }
    }
}
