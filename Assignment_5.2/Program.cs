using System;

namespace Assignment_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            int[,] result = new int[2, 2];
            Console.WriteLine("enter the elements of first matrix");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    arr1[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("enter the elements of second matrix");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    result[i,j] = 0;
                    for(int k=0;k<2;k++)
                    {
                        result[i,j] = result[i,j]+ (arr1[i,k] * arr2[k,j]);
                    }
                }
            }

            Console.WriteLine("Matrix multiplication of two matrices is");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write(result[i,j]+"\t");
                }
                Console.WriteLine();
            }

        }
    }
}
