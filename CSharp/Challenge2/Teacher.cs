using System;

namespace School
{
    class Teacher : Employee
    {
        private string taughtClasses;
        private int numClassesTaught;
        public Teacher(ref int employees)
        {
            School.teachers++;
            employees++;
            this.employeeId = employees;
            this.employeeAddress.Street = "";
            this.employeeAddress.City = "";
            this.employeeAddress.State = "";
            this.employeeAddress.ZipCode = "";
            this.employeeContact.PhoneNumber = "";
            this.employeeContact.Email = "";
        }
        public void printClasses()
        {
            Console.WriteLine($"This teacher is teaching:");
            Console.WriteLine(this.taughtClasses);
        }
        public void teachMath()
        {
            if (this.numClassesTaught == 0)
            {
                this.taughtClasses = $"{Classes.Math}";
            }
            else
            {
                this.taughtClasses = $"{this.taughtClasses} {Classes.Math}";
            }
            Console.WriteLine("Teacher is now teaching Math");
            numClassesTaught++;
        }
        public void teachReading()
        {
            if (this.numClassesTaught == 0)
            {
                this.taughtClasses = $"{Classes.Reading}";
            }
            else
            {
                this.taughtClasses = $"{this.taughtClasses} {Classes.Reading}";
            }
            Console.WriteLine("Teacher is now teaching Reading");
            numClassesTaught++;
        }
        public void teachHistory()
        {
            if (this.numClassesTaught == 0)
            {
                this.taughtClasses = $"{Classes.History}";
            }
            else
            {
                this.taughtClasses = $"{this.taughtClasses} {Classes.History}";
            }
            Console.WriteLine("Teacher is now teaching History");
            numClassesTaught++;
        }
        public void teachScience()
        {
            if (this.numClassesTaught == 0)
            {
                this.taughtClasses = $"{Classes.Science}";
            }
            else
            {
                this.taughtClasses = $"{this.taughtClasses} {Classes.Science}";
            }
            Console.WriteLine("Teacher is now teaching Science");
            numClassesTaught++;
        }
        public void teachEnglish()
        {
            if (this.numClassesTaught == 0)
            {
                this.taughtClasses = $"{Classes.English}";
            }
            else
            {
                this.taughtClasses = $"{this.taughtClasses} {Classes.English}";
            }
            Console.WriteLine("Teacher is now teaching English");
            numClassesTaught++;
        }
    }
}