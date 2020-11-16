using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9._4
{
    class Employee : Person
    {
      public  double annualSalary;
       public  int year;
       public  string nationalInsuranceNum;
       
      
        
        public Employee(int Sal,int Year,string NIN)
        {
            annualSalary = Sal;
            year = Year;
            nationalInsuranceNum = NIN;
        }
        public Employee(int Sal, int Year, string NIN, string Name)
        {
            annualSalary = Sal;
            year = Year;
            nationalInsuranceNum = NIN;
            name = Name;
        }
        public void Display()
        {
            Console.WriteLine("The details of the person are");
            Console.WriteLine("Name : "+name );
            Console.WriteLine("Year of joining : "+year);
            Console.WriteLine("National Insurance Number : "+nationalInsuranceNum);
            Console.WriteLine("The annual salary is : "+annualSalary);
        }
    }

}
