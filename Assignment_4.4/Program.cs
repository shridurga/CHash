using System;
using System.Linq;

namespace Assignment_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            String s;
            Console.WriteLine("Enter a string");
            s = Console.ReadLine();

            Console.WriteLine("1. Printing the string in reverse order");
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);

            Console.WriteLine("2. Extracting part of the string from 2nd position till the end of the string ");
            Console.WriteLine(s.Substring(1));

            Console.WriteLine("3.Enter a character to be replaced with $");
            char r;
            r = char.Parse(Console.ReadLine());
            Console.WriteLine("String after the replacement is ");
            for (int i = 0; i <s.Length;i++)
            {
                if(s[i]==r)
                {
                    Console.Write("$");
                }
                else
                    Console.Write(s[i]);
            }
            string copied_string;
            copied_string = s;
            Console.WriteLine("4. Actual string value is "+s);
            Console.WriteLine("Value of copied string is "+copied_string);

        }

      
    }
}
