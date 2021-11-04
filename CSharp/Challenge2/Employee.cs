using System;

namespace School
{
    class Employee
    {
        // Fields Do I need to make this public for the other classes to uses?
        protected int employeeId;

        // Don't need a constructor because this class is abstract and just inherited???
        //
        // public Employee(ref int employee)
        // {
        //     employee++;
        //     this.employeeId = employee;
        // }
    }
}