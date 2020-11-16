using System;

namespace Assignment_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for(int i=1;i<=18;i++)
            {
                c = a + b;
                Console.WriteLine(c+" ");
                a = b;
                b = c;
            }
        }
    }
}
