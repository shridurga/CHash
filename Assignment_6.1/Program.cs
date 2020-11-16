using System;

namespace Assignment_6._1
{
    class Program
    {
        
        public delegate void MethodPointer(int[] y);
        static void Main(string[] args)
        {
          
            int[] a = {4,5,1,2};
            int[] c = { 4,5,1,2};

            

            MethodPointer obj1 = new MethodPointer(Print);      
            obj1(a);
           

            MethodPointer obj2 = new MethodPointer(Sort);
            obj2(a);
           

            MethodPointer obj3 = new MethodPointer(Reverse);
            obj3(c);

           


        }


        static void Print(int[] y)
        {
            Console.WriteLine("The elements of the array are ");

            for (int i=0;i<y.Length;i++)
            {
                Console.Write(y[i]);
            }
            Console.WriteLine();
        }
        static void Sort(int[] z)
        {
            for(int i=0;i<z.Length;i++)
            {
                for(int j=0;j<z.Length-i-1;j++)
                {
                    if(z[j]>z[j+1])
                    {
                        int temp;
                        temp = z[j];
                        z[j] = z[j + 1];
                        z[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("The array after sorting is");
            for(int i = 0; i < z.Length; i++)
            {
                Console.Write(z[i]);
            }
            Console.WriteLine();
        }

        static void Reverse(int[] a)
        {
            Console.WriteLine("The array after reversing is");
            for(int i=a.Length-1;i>=0;i--)
            {
                Console.Write(a[i]);
            }
        }

    }
}
