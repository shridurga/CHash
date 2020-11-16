using System;

namespace Assignment_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num;
            num = int.Parse(Console.ReadLine());
            EvenOrOdd(num);
        }
       public static void EvenOrOdd(int num)
        {
            if(num%2 == 0)
                Console.WriteLine("The given number is Even");
            else
                Console.WriteLine("The given number is odd");
        }
    }

}
