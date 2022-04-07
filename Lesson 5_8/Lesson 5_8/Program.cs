using System;

namespace Logic
{
    class Programm 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, pls enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Super. enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Super. enter your gender: \n enter 0 - wooman\n enter 1 - man");
            int gender = Convert.ToInt32(Console.ReadLine());

            if (gender == 1)
            {
                Console.WriteLine($"Hello Mister,{name}");
            }

            else if (age >= 40 )
            {
                Console.WriteLine($"Hello Mrs.{name}");
            }
            else
            {
                Console.WriteLine($"Hello Miss.{name}");
            }
        }
    }
}