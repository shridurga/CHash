using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any five numbers");
            int[] array= new int[5];
          
            for(int i=0;i<5;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The numbers in the array are ");
            for(int i=0;i<5;i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}
