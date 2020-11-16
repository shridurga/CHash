using System;

namespace Assignment_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3,5];
    
            array = Method();
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<5;j++)
                {
                    Console.Write(array[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }

        public static int[,]  Method()
        {
            int[,] arr = new int[3, 5];
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<5;j++)
                {
                    arr[i, j] = 42;
                }
            }
            return arr;
        }
    }
}
