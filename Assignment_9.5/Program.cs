using System;

namespace Assignment_9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Instrument[] i = new Instrument[10];


            for (int j = 0; j <= 3; j++)
            {
                i[j] = new Flute();
            }
            for (int j = 4; j <= 7; j++)
            {
                i[j] = new Guitar();
            }
            for (int j = 7; j <= 9; j++)
            {
                i[j] = new Piano();
            }

            for (int j = 0; j < 10; j++)
            {
                i[j].Play();
            }
            Console.ReadLine();


          /*  if(i[7] instanceof Piano)
            {
                Console.WriteLine("At 7 the instance of Piano is present");
            }
            else
            {

            }*/

        }


    }
}

