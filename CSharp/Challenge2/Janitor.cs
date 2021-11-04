using System;

namespace School
{
    class Janitor : Employee
    {
        // Inherits employeeId from Employee

        // Constructor
        public Janitor(ref int employees)
        {
            School.janitors++;
            employees++;
            this.employeeId = employees;
        }
    }
}