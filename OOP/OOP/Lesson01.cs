using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Lesson01
    {
        class Person
        {
            protected int age;

            public void Greet()
            {
                Console.WriteLine("Hello");
            }

            public void SetAge(int n)
            {
                age = n;
            }
        }
        class Student : Person
        {
            public void ShowAge()
            {
                Console.WriteLine("My age is: {0} years old", age);
            }
        }
        class Teacher : Person
        {
            public void ShowAge()
            {
                Console.WriteLine("My age is: {0} years old", age);
            }
            private string subject;

            public void Explain()
            {
                Console.WriteLine("Explanation begins");
            }
        }
        class StudentAndTeacherTest
        {
            static void Main()
            {
                bool debug = false;

                Person myPerson = new Person();


                Student myStudent = new Student();
                myStudent.SetAge(21);
                myStudent.Greet();
                myStudent.ShowAge();

                Teacher myTeacher = new Teacher();
                myTeacher.SetAge(30);
                myTeacher.Greet();
                myTeacher.ShowAge();
                myTeacher.Explain();

                if (debug)
                    Console.ReadLine();
            }
        }
    }
}
