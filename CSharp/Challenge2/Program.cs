using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSTUDENTS");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"The total number of students is: {School.getStudents()}\n");
            Console.WriteLine("Making 3 students...");
            Student student_1 = new Student(ref School.students);
            Student student_2 = new Student(ref School.students);
            Student student_3 = new Student(ref School.students);
            Console.WriteLine($"The total number of students is: {School.getStudents()}");
            Console.WriteLine("\nTEACHERS");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"The total number of teachers is: {School.getTeachers()}");
            Console.WriteLine("Making 3 teachers.");
            Teacher teacher_1 = new Teacher(ref School.employees);
            Teacher teacher_2 = new Teacher(ref School.employees);
            Teacher teacher_3 = new Teacher(ref School.employees);
            Console.WriteLine($"The total number of teachers is: {School.getTeachers()}");
            Console.WriteLine($"The total number of employees is: {School.getEmployees()}");
            Console.WriteLine("\nJANITORS");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Making 3 janitors.");
            Janitor janitor_1 = new Janitor(ref School.employees);
            Janitor janitor_2 = new Janitor(ref School.employees);
            Janitor janitor_3 = new Janitor(ref School.employees);
            Console.WriteLine($"The total number of janitors is: {School.getJanitors()}");
            Console.WriteLine($"The total number of employees is: {School.getEmployees()}");
            Console.WriteLine("\nTotal Number of Classes");
            Console.WriteLine("----------------------------");
            Console.WriteLine("The number of available classes is: ");
            Console.WriteLine(School.getNumClasses());
            School.getListOfClasses();

            Console.WriteLine("\nEnroll Student in Classes");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enrolling student 1 in Math and Reading");
            student_1.enrollInMath();
            student_1.enrollInReading();
            student_1.printClasses();
            Console.WriteLine("\nTeach Classes");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Making teacher 2 teach English and History.");
            teacher_2.teachEnglish();
            teacher_2.teachHistory();
            teacher_2.printClasses();

            Console.WriteLine("\nSetting Student 1's Address...");
            Console.WriteLine("----------------------------");
            student_1.studentAddress.Street = "123 West 4th Street";
            student_1.studentAddress.City = "Bellingham";
            student_1.studentAddress.State = "WA";
            student_1.studentAddress.ZipCode = "12345";
            student_1.studentContact.PhoneNumber = "123-456-7890";
            student_1.studentContact.Email = "student1@school.edu";
            student_1.studentAddress.printAddress();
            student_1.studentContact.printContact();

            Console.WriteLine("\nEND OF PROGRAM");
            Console.WriteLine("----------------------------");
            Console.ReadKey();
        }
    }
}
