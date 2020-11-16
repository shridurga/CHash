using System;

namespace Assignment_9._4
{
    class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(20000,2019,"123456");
            e1.name = "Indira";
            e1.Display();
            Employee e2 = new Employee(25000,2017,"234567", "Sri Durga");
            e2.Display();

        }
    }
}
