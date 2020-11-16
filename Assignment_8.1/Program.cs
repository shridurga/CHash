using System;
using System.Reflection.Emit;

namespace Assignment_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string S1_Name;
            Label tryagain = new Label();
            int[] marks_student1 = new int[3];
            bool flag1= true;
            Console.WriteLine("Enter the student name and his marks for sub1, sub2, sub3");
            S1_Name = Console.ReadLine();
            for(int i=0;i<3;i++)
            {
                flag1 = true;
                while(flag1==true)
                try
                {
                    
                    marks_student1[i] = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);

                        flag1 = false;
                        Console.WriteLine("Enter the marks again");
                }
           }

            Student Student1 = new Student(S1_Name,marks_student1[0],marks_student1[1],marks_student1[2]);
            Student1.average();
            Console.ReadLine();
        }
    }

    class Student
    {
        string Name;
        int subject1_marks;
        int subject2_marks;
        int subject3_marks;

        public Student(string aName, int aMarks1,int aMarks2,int aMarks3)
        {
            Name = aName;
            subject1_marks = aMarks1;
            subject2_marks = aMarks2;
            subject3_marks = aMarks3;
        }
        public void average()
        {
            int avg;
            try
            {
                avg = (subject1_marks + subject2_marks + subject3_marks) / 3;
                Console.WriteLine(avg);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
            
    }
    
}
