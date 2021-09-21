using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = 15;
            

            if (a % 2 == 0)
                Console.WriteLine("$ {a} jest liczbą parzystą");
            else
                Console.WriteLine($"{a} jest liczbą nieparzystą");


            Console.ReadKey();

           
          
        }
    }
}
