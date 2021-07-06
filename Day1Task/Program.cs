using System;

namespace Day1Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student's name
            Console.WriteLine("Enter your name: ");

            var studentName = Console.ReadLine();

            //Student's roll no
            Console.WriteLine("Enter your roll no: ");

            int studentrollNo = Convert.ToInt32(Console.ReadLine());

            //Student's age
            Console.WriteLine("Enter your age: ");

            int studentAge = Convert.ToInt32(Console.ReadLine());

            //Student's class
            Console.WriteLine("Enter your class: ");

            var studentClass = Console.ReadLine();

            //Student's University name

            Console.WriteLine("Enter your school name: ");

            var universityName = Console.ReadLine();

            Console.WriteLine("\nHere is the student's details:\n");
            Console.WriteLine(studentName);
            Console.WriteLine(studentrollNo);
            Console.WriteLine(studentAge);
            Console.WriteLine(studentClass);
            Console.WriteLine(universityName);
        }
    }
}
