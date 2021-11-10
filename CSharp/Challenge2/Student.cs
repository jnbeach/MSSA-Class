using System;
using System.Collections.Generic;

namespace School
{
    class Student
    {
        // Fields
        private int studentId;
        private string enrolledClasses;
        private string grade;

        private int numClassesEnrolled;

        public Address studentAddress;
        public Contact studentContact;

        // Constructor
        public Student(ref int student)
        {
            student++;
            this.studentId = student;
            this.studentAddress.Street = "";
            this.studentAddress.City = "";
            this.studentAddress.State = "";
            this.studentAddress.ZipCode = "";
            this.studentContact.PhoneNumber = "";
            this.studentContact.Email = "";
        }
        public void addGrade<T>(T gradeInput)
        {
            this.grade = Convert.ToString(gradeInput);
            string convertedGrade = convertGrade(gradeInput);
            Console.WriteLine($"Student has a grade of {gradeInput}, which is equivalent to: {convertedGrade}");
        }
        private string convertGrade<T>(T gradeInput)
        {
            string gradeString = Convert.ToString(gradeInput);
            Dictionary<string, string> gradeConversion = new Dictionary<string, string>();
            gradeConversion.Add("5", "F");
            gradeConversion.Add("6", "D");
            gradeConversion.Add("7", "C");
            gradeConversion.Add("8", "B");
            gradeConversion.Add("9", "A");
            gradeConversion.Add("10", "A+");
            gradeConversion.Add("F", "5");
            gradeConversion.Add("D", "6");
            gradeConversion.Add("C", "7");
            gradeConversion.Add("B", "8");
            gradeConversion.Add("A", "9");
            gradeConversion.Add("A+", "10");
            return gradeConversion[gradeString];
        }

        // public void numberNote(ref Dictionary<string, int> gradeConversion)
        // {

        // }

        public void printClasses()
        {
            Console.WriteLine($"This student is enrolled in:");
            Console.WriteLine(this.enrolledClasses);
        }
        public void enrollInMath()
        {
            if (this.numClassesEnrolled == 0)
            {
                this.enrolledClasses = $"{Classes.Math}";
            }
            else
            {
                this.enrolledClasses = $"{this.enrolledClasses} {Classes.Math}";
            }

            Console.WriteLine("Student is now enrolled in Math");
            numClassesEnrolled++;
        }
        public void enrollInReading()
        {
            if (this.numClassesEnrolled == 0)
            {
                this.enrolledClasses = $"{Classes.Reading}";
            }
            else
            {
                this.enrolledClasses = $"{this.enrolledClasses} {Classes.Reading}";
            }
            Console.WriteLine("Student is now enrolled in Reading");
            numClassesEnrolled++;
        }
        public void enrollInHistory()
        {
            if (this.numClassesEnrolled == 0)
            {
                this.enrolledClasses = $"{Classes.History}";
            }
            else
            {
                this.enrolledClasses = $"{this.enrolledClasses} {Classes.History}";
            }
            Console.WriteLine("Student is now enrolled in History");
            numClassesEnrolled++;
        }
        public void enrollInScience()
        {
            if (this.numClassesEnrolled == 0)
            {
                this.enrolledClasses = $"{Classes.Science}";
            }
            else
            {
                this.enrolledClasses = $"{this.enrolledClasses} {Classes.Science}";
            }
            Console.WriteLine("Student is now enrolled in Science");
            numClassesEnrolled++;
        }
        public void enrollInEnglish()
        {
            if (this.numClassesEnrolled == 0)
            {
                this.enrolledClasses = $"{Classes.English}";
            }
            else
            {
                this.enrolledClasses = $"{this.enrolledClasses} {Classes.English}";
            }
            Console.WriteLine("Student is now enrolled in English");
            numClassesEnrolled++;
        }
    }
}
