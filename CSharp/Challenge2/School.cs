using System;

namespace School
{
    class School
    {
        public static int students;
        public static int teachers;
        public static int janitors;
        public static int employees;
        public static int numOfClasses = Enum.GetNames(typeof(Classes)).Length;
        public static string[] listOfClasses = Enum.GetNames(typeof(Classes));

        // Constructor
        public School()
        {
            students = 0;
            teachers = 0;
            janitors = 0;
            employees = 0;
            numOfClasses = Enum.GetNames(typeof(Classes)).Length;
            listOfClasses = Enum.GetNames(typeof(Classes));
        }

        // Method
        public static int getStudents()
        {
            return students;
        }

        // Amount of teachers
        public static int getTeachers()
        {
            return teachers;
        }

        // Amount of janitors
        public static int getJanitors()
        {
            return janitors;
        }

        // Amount of employees

        public static int getEmployees()
        {
            return employees;
        }
        public static int getNumClasses()
        {
            return numOfClasses;
        }
        public static void getListOfClasses()
        {
            Console.WriteLine("List of Classes: ");
            for (int i = 0; i < listOfClasses.Length; i++)
            {
                Console.WriteLine(listOfClasses[i]);
            }
        }
    }
}
