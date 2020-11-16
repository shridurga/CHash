    using System;

namespace Assignment_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
             int divident, divisor, result=0    ;
            Console.WriteLine("Enter the value of divident");
            divident = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of divisor");           
            divisor = int.Parse(Console.ReadLine());
            try
            {
                result = divident / divisor;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Exception caught "+e);
            }
            finally
            {
                Console.WriteLine(result);
            }

        }
    }
}
