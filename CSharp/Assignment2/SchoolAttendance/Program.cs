using System;
using System.Collections.Generic;

namespace SchoolAttendance
{
    public class Guards
    {
        public static void OnStudentMissing()
        {
            Console.WriteLine($"Guards are on their way!");
        }
    }
    public class Teacher
    {
        //Define a Delegate
        public delegate void StudentMissingEventHandler();
        //Define an event based on that delegate
        public event StudentMissingEventHandler StudentMissing;
        //Subscribe events

        //Raise the event
        public void OnStudentMissing()
        {
            yellSomething();
            if (StudentMissing != null)
                StudentMissing();
        }
        public void yellSomething()
        {
            Random randNumber = new Random();
            int response = randNumber.Next(4) + 1;
            switch (response)
            {
                case 1:
                    Console.WriteLine("I WILL SHOW YOU JUSTICE!!!");
                    Console.WriteLine("HOW ABOUT A ZERO FOR THIS CLASS????");
                    break;
                case 2:
                    Console.WriteLine("How DARE YOU! I AM THE NIGHT!!!");
                    Console.WriteLine("YOUR FUTURE IN THIS CLASS IS VERY DARK. HAVE A ZERO.");
                    break;
                case 3:
                    Console.WriteLine("GET BACK HERE OR I WILL BREAK YOU.");
                    Console.WriteLine("THAT'S A ZERO FOR YOU.");
                    break;
                case 4:
                    Console.WriteLine("DON'T MAKE ME COME FIND YOU.");
                    Console.WriteLine("WHY DON'T YOU TAKE A ZERO?");
                    break;
                default:
                    break;
            }
        }
        public string Name { get; private set; }
        public Teacher(string name)
        {
            this.Name = name;
        }
        public void TakeAttendance(List<Student> roster)
        {
            foreach (Student student in roster)
            {
                Console.WriteLine($"Is {student.Name} here?");
                if (student.IsPresent)
                {
                    Console.WriteLine("Yes.");
                    Console.WriteLine("--------------------------");

                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine("--------------------------");
                    OnStudentMissing();
                    student.Grade = 0;
                }
            }
        }
    }
    public class Student
    {
        public string Name { get; private set; }
        public int Grade { get; set; }

        public int IsPresentInt { get; set; }
        public bool IsPresent { get; set; }
        private Random randNumber = new Random();
        public Student(string name)
        {
            this.Name = name;
            this.Grade = 100;
            IsPresentInt = this.randNumber.Next(2);
            if (IsPresentInt == 1)
            {
                this.IsPresent = true;
            }
            else
            {
                this.IsPresent = false;
            }

        }
        public void EnrollStudent(ClassList dummyClass)
        {
            dummyClass.Roster.Add(this);
            Console.WriteLine($"{this.Name} has been enrolled in {dummyClass.ClassName}.");
        }
    }
    public class ClassList
    {
        public string ClassName { get; set; }
        public List<Student> Roster = new List<Student>();
        public ClassList(string name)
        {
            this.ClassName = name;
        }
        public void PrintClassList()
        {
            Console.WriteLine($"Your class roster for {this.ClassName} is as follows:");
            Console.WriteLine($"------------------------------------------------------\n");
            foreach (Student student in this.Roster)
            {
                Console.Write($"{student.Name} ");
            }
            Console.WriteLine($"\n\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Arkham Asylum Attendance Manager");
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine("Please wait while I populate your roster...");
            Console.WriteLine("Loading...\n");
            ClassList Rehabilitation101 = new ClassList("Rehab 101");
            Student Joker = new Student("Joker");
            Joker.EnrollStudent(Rehabilitation101);
            Student Scarecrow = new Student("Scarecrow");
            Scarecrow.EnrollStudent(Rehabilitation101);
            Student TwoFace = new Student("TwoFace");
            TwoFace.EnrollStudent(Rehabilitation101);
            Student MisterFreeze = new Student("MisterFreeze");
            MisterFreeze.EnrollStudent(Rehabilitation101);
            Student Penguin = new Student("Penguin");
            Penguin.EnrollStudent(Rehabilitation101);
            Rehabilitation101.PrintClassList();
            Teacher Batman = new Teacher("Batman");
            Batman.StudentMissing += Guards.OnStudentMissing;
            Console.WriteLine("Taking attendance now:");
            Console.WriteLine("-------------------------------------------");
            Batman.TakeAttendance(Rehabilitation101.Roster);
        }

    }
}
