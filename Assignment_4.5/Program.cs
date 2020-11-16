using System;

namespace Assignment_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int DayNum;
            Console.WriteLine("Enter an integer day number between 1 and 365");
            DayNum = int.Parse(Console.ReadLine());
            if(1<=DayNum && DayNum <=31)
            {
                Console.WriteLine("January "+(DayNum));
            }
            else if(32<=DayNum && DayNum<=59)
            {
                Console.WriteLine("February "+(DayNum-31));
            }
            else if(60<=DayNum && DayNum<=90)
            {
                Console.WriteLine("March "+ (DayNum-59));
            }
            else if(91<=DayNum && DayNum<=120)
            {
                Console.WriteLine("April "+ (DayNum-90));
            }
            else if(121<= DayNum && DayNum<=151 )
            {
                Console.WriteLine("May "+(DayNum-120));
            }
            else if(152<=DayNum && DayNum<= 181)
            {
                Console.WriteLine("June "+(DayNum-151));
            }
            else if(182<=DayNum && DayNum<= 212)
            {
                Console.WriteLine("July " +(DayNum-181));
            }
            else if(213<=DayNum && DayNum<= 243)
            {
                Console.WriteLine("August " +(DayNum-212));
            }
            else if(244<=DayNum && DayNum<= 273)
            {
                Console.WriteLine("September "+(DayNum-243));
            }
            else if(274<=DayNum && DayNum<= 304)
            {
                Console.WriteLine("October " +(DayNum-273));
            }
            else if(305<=DayNum && DayNum<= 334)
            {
                Console.WriteLine("November ");
            }
            else if(335<=DayNum && DayNum<= 365)
            {
                Console.WriteLine("December "+(DayNum-334));
            }
        }
    }
}
