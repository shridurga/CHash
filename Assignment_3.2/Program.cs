using System;

namespace Assignment_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side of the square");
            long area, side;
            side = int.Parse(Console.ReadLine());
            area = side * side;
            Console.WriteLine("The area of the square is "+area );
        }
    }
}
