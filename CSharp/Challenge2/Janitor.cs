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
            this.employeeAddress.Street = "";
            this.employeeAddress.City = "";
            this.employeeAddress.State = "";
            this.employeeAddress.ZipCode = "";
            this.employeeContact.PhoneNumber = "";
            this.employeeContact.Email = "";
        }
    }
}