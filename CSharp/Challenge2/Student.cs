using System;

namespace School
{
    class Student
    {
        // Fields
        private int studentId;
        private string enrolledClasses;

        private int numClassesEnrolled;

        // Constructor
        public Student(ref int student)
        {
            student++;
            this.studentId = student;
        }
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
