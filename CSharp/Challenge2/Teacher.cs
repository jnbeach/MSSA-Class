using System;

namespace School
{
    class Teacher : Employee
    {
        // Inherits employeeId from Employee

        // Constructor
        public Teacher(ref int employees)
        {
            School.teachers++;
            employees++;
            this.employeeId = employees;
        }
    }
}