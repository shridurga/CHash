using System;

namespace Assignment_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("SriDurga", 90000);
            e.CalculateNetPay();
            e.Display();
        }
    }

    class Employee
    {
       public string Name;
       public double BasicSalary, HRA, DA, TAX, GrossPay, NetSalary;
           
      public  Employee(string aName,int aBasicSal)
        {
            Name = aName;
            BasicSalary = aBasicSal;
        }
       public void CalculateNetPay()
        {
            HRA = (0.15) * BasicSalary;
            DA = (0.1) * BasicSalary;
            GrossPay = BasicSalary + HRA + DA;
            TAX = (0.08) * GrossPay;
            NetSalary = GrossPay - TAX;
        }
        public void Display()
        {
            Console.WriteLine("The salary structure of "+Name+" is");
            Console.WriteLine("Basic Salary = "+BasicSalary);
            Console.WriteLine("HRA = "+HRA);
            Console.WriteLine("DA = "+DA);
            Console.WriteLine("Gross Pay = "+GrossPay);
            Console.WriteLine("TAX = "+TAX);
            Console.WriteLine("Net Salary is (Gross Pay - TAX) = "+NetSalary);
        }

    }
}
