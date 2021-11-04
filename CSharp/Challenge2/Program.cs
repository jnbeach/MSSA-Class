using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make 3 Students
            Console.WriteLine($"The total number of students is: {School.getStudents()}");
            Console.WriteLine("Making 3 students.");
            Student student_1 = new Student(ref School.students);
            Student student_2 = new Student(ref School.students);
            Student student_3 = new Student(ref School.students);
            Console.WriteLine($"The total number of students is: {School.getStudents()}");
            Console.WriteLine($"The total number of teachers is: {School.getTeachers()}");
            Console.WriteLine("Making 3 teachers.");
            Teacher teacher_1 = new Teacher(ref School.employees);
            Teacher teacher_2 = new Teacher(ref School.employees);
            Teacher teacher_3 = new Teacher(ref School.employees);
            Console.WriteLine($"The total number of teachers is: {School.getTeachers()}");
            Console.WriteLine($"The total number of employees is: {School.getEmployees()}");
            Console.WriteLine("Making 3 janitors.");
            Janitor janitor_1 = new Janitor(ref School.employees);
            Janitor janitor_2 = new Janitor(ref School.employees);
            Janitor janitor_3 = new Janitor(ref School.employees);
            Console.WriteLine($"The total number of janitors is: {School.getJanitors()}");
            Console.WriteLine($"The total number of employees is: {School.getEmployees()}");
        }
    }
}
