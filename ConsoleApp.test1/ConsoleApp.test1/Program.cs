using System;
using ClassLibrary.Test;

namespace ConsoleApp.test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[0];
            int len = 0;
            l1:
            Class1.PrintMenu();
            int Userreqem = Convert.ToInt32(Console.ReadLine());

            switch (Userreqem)
            {
                case 1:
                    Student student = new Student();
                    student.Name = Console.ReadLine();
                    student.surname = Console.ReadLine();
                    student.Address= Console.ReadLine();
                    Array.Resize(ref students, students.Length + 1);
                    len = students.Length - 1;
                    students[len] = student;

                    Console.WriteLine("geri donus et 3");
                    int sub2 = Convert.ToInt32(Console.ReadLine());
                    if (sub2==3)
                    {
                        goto l1;
                    }


                    break;
                case 2:
                    foreach (var item in students)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("geri donush et 3");
                    int subMenu = Convert.ToInt32(Console.ReadLine());
                    if (subMenu==3)
                    {
                        goto l1;
                    }
                    break;


                default:
                break;
            }

        }
                


    }
}

