using System;
using System.Runtime.InteropServices.ComTypes;

namespace Assignment_9._3
{
    class Program 
    {
        static void Main(string[] args)
        {

            Fan f1 = new Fan();
            f1.Speed = f1.Speed;
            f1.Radius = 10;
            f1.toString();
        }

    }

    class Fan
    {
        static int slow=1, medium=2, fast=3;
        private int speed = slow;
        private bool SwitchButton = false;
        private double radius = 5;
        private string colour = "red";

        public Fan()
        {

        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public bool Switch
        {
            get { return SwitchButton; }
            set { SwitchButton = value;  }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public void toString()
        {
            Console.WriteLine("Current status of the Fan is: ");
        Console.WriteLine("Colour of Fan is : "+ colour);
            Console.WriteLine("Radius of Fan is : "+radius);
          Console.WriteLine("Speed of Fan is : "+speed);
            
           
        }
    }
}
