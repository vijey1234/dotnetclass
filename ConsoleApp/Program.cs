using System;

namespace ConsoleApp
{
     public class Program
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
        public void TestAdd2()
        {

        }
    }

    public class Program1:Program
    {
      public  Program1()
        {
            int y = 10;
        }
        Program1(int x)
        {
            int y = 9;
        }
        static void TestAdd()
        {
            Program obj = new Program();
            
           
        }
        public void main()
        {
            TestAdd2();
        }
        
        
    }
    class Program2:Program1
    {
       void TestAdd3() {
        }
        Program1 objprogram1 = new Program1();
        objprogram1
    }
}
