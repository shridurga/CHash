using System;

namespace Assignment_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            String s,reverse="";
            Console.WriteLine("Enter a string");
            s = Console.ReadLine();
            int l = s.Length;
            for(int i=l-1;i>=0;i--)
            {
                reverse += s[i].ToString();
            }
            for(int i=0;i<l;i++)
            {
                Console.WriteLine(reverse[i]);
            }
            if(s == reverse)
            {
                Console.WriteLine("Entered string is palindrome");
            }
            else
            {
                Console.WriteLine("Entered string is not palindrome");
            }



        }
    }
}
