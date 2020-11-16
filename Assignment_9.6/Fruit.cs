using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9._6
{
    class Fruit
    {

        public string name;
        public string taste;
        public int size;

        public Fruit(string aName,string aTaste,int aSize)
        {
            name = aName;
            taste = aTaste;
            size = aSize;
        }
        public Fruit(string aTaste,int aSize)
        {
            taste = aTaste;
            size = aSize;
        }
        public Fruit(string aTaste)
        {
            taste = aTaste;
        }
        public Fruit()
        {

        }
        public void eat()
        {
            Console.WriteLine("The name of the fruit is "+name);
            Console.WriteLine("The taste of "+name+" is "+taste);
        }
    }
}
