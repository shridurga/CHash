using System;
using System.Globalization;
using System.Reflection.Emit;
using System.Threading;

namespace Assignment_8._2
{

    class Program
    {
        static void Main(string[] args)
        {
            string S1_Name, S2_Name;

            int[] marks_student1 = new int[3];
            int[] marks_student2 = new int[3];

            Console.WriteLine("Enter the first student name and his marks for sub1, sub2, sub3");
            S1_Name = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    marks_student1[i] = int.Parse(Console.ReadLine());
                    if (marks_student1[i] < 0 || marks_student1[i] > 100)
                    {
                        throw new OutOfRangeNumberException();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            Console.WriteLine("Enter the second student name and his marks for sub1, sub2, sub3");
            S2_Name = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    marks_student2[i] = int.Parse(Console.ReadLine());
                    if (marks_student2[i] < 0 || marks_student2[i] > 100)
                    {
                        throw new OutOfRangeNumberException();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            Student Student1 = new Student(S1_Name, marks_student1[0], marks_student1[1], marks_student1[2]);
            Student1.sum();
            Student Student2 = new Student(S2_Name, marks_student2[0], marks_student2[1], marks_student2[2]);
            Student2.sum();
            Student.avg();
            Console.ReadLine();
        }
    }

    public class OutOfRangeNumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "Number out of range. It can only be from 0 to 100";
            }
        }
    }

    class Student
    {
        string Name;
        int subject1_marks;
        int subject2_marks;
        int subject3_marks;
        static int[] average = new int[2];
        static int Count =0;
      
        public Student(string aName, int aMarks1, int aMarks2, int aMarks3)
        {
            Name = aName;
            subject1_marks = aMarks1;
            subject2_marks = aMarks2;
            subject3_marks = aMarks3;
        }
        public void sum()
        {
            int sum;
            try
            {
                sum = (subject1_marks + subject2_marks + subject3_marks);
                Console.WriteLine("The total marks of the student is "+sum);
                average[Count] = sum;
                Count++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void avg()
        {
          
            Console.WriteLine("The average of marks of both students is" +((average[0]+average[1])/2));
        }


    }
}

    
