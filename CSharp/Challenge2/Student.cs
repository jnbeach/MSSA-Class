using System;

namespace School
{
    class Student
    {
        // Fields
        private int studentId;

        // Constructor
        public Student(ref int student)
        {
            student++;
            this.studentId = student;
        }
    }
}
