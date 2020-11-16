using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Assignment_9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RamdomHelper.randint(3,4);
            RamdomHelper.randdouble(1, 10);
        }
    }

   public class RamdomHelper
    {
        public  static int randint( int x, int y)
        {
            Random r = new Random();
            int num = Random.Next(x, y + 1);
            return num;

        }
       public static double randdouble(int x, int y)
        {
            return Random.NextDouble(x, y);
          
        }
    }
}
