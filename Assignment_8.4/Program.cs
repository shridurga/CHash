using System;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_8._4
{
    class Program
    {
        static void Main(string[] args)
        {

            int DayNum;
            int year;
            int i;
            Console.WriteLine("Enter an integer day number between 1 and 365");
            DayNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the year ");
            year = int.Parse(Console.ReadLine());
            
           bool Flag = LeapYearOrNot(year);

            if(Flag == true)
            {
                i = 1;
            }
            else
            {
                i = 0;
            }

            try
            {
                if (DayNum < 0 || DayNum > 365)
                {
                    throw new InvalidArgumentException();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            if (1 <= DayNum && DayNum <= 31)
            {
                Console.WriteLine("January " + (DayNum));
            }
            else if (32 <= DayNum && DayNum <= 59+i)
            {
                Console.WriteLine("February " + (DayNum - 31-i));
            }
            else if (60+i <= DayNum && DayNum <= 90+i)
            {
                Console.WriteLine("March " + (DayNum - 59-i));
            }
            else if (91+i <= DayNum && DayNum <= 120+i)
            {
                Console.WriteLine("April " + (DayNum - 90-i));
            }
            else if (121+i <= DayNum && DayNum <= 151+i)
            {
                Console.WriteLine("May " + (DayNum - 120-i));
            }
            else if (152+i <= DayNum && DayNum <= 181+i)
            {
                Console.WriteLine("June " + (DayNum - 151-i));
            }
            else if (182+i <= DayNum && DayNum <= 212+i)
            {
                Console.WriteLine("July " + (DayNum - 181-i));
            }
            else if (213+i <= DayNum && DayNum <= 243+i)
            {
                Console.WriteLine("August " + (DayNum - 212-i));
            }
            else if (244+i <= DayNum && DayNum <= 273+i)
            {
                Console.WriteLine("September " + (DayNum - 243-i));
            }
            else if (274 +i<= DayNum && DayNum <= 304+i)
            {
                Console.WriteLine("October " + (DayNum - 273-i));
            }
            else if (305 +i<= DayNum && DayNum <= 334+i)
            {
                Console.WriteLine("November " + (DayNum - 304-i));
            }
            else if (335 +i<= DayNum && DayNum <= 365+i)
            {
                Console.WriteLine("December " + (DayNum - 334-i));
            }
        }

        public static bool LeapYearOrNot(int x)
        {


            if (x % 4 == 0)
            {
                //Nested if else
                if (x % 100 == 0)
                {
                    if (x % 400 == 0)
                    {
                        //  printf("%d is a Leap Year", x);
                        Console.WriteLine("Entered year is leap year");
                        return true;
                    }
                    else
                    {
                        //  printf("%d is not a Leap Year", x);
                        Console.WriteLine("Entered year is not a leap year");
                        return false;
                    }
                }
                else
                {

                    //  printf("%d is a Leap Year", x);
                    Console.WriteLine("Entered year is leap year");
                    return true;
                }
            }


            else 
                {
                    // printf("%d is not a Leap Year", x);
                    Console.WriteLine("Entered year is not a leap year");
                    return false;
                }
           
        }

    }

    public class InvalidArgumentException : Exception
    {
        public override string Message
        {
            get
            {
                return "Day out of range. It can only be from 1 to 365";
            }
        }
    }

    

}