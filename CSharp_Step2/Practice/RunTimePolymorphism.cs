using System;
namespace RuntimPolyPrcatice
{
    class Employeone
    {
        public virtual string EmployeDetails(string EmpName)
        {
            Console.WriteLine($"Name of the first Employe is {EmpName}.");
            return EmpName;
        }
        public virtual double EmployeDetails(double salary)
        {
            Console.WriteLine($"Salary of first Employe is {salary}");
            return salary;

        }
    }

    class EmployeeTwo:Employeone
    {

        public override string EmployeDetails(string EmpName)
        {
            Console.WriteLine($" Name of the second employee is {EmpName}.");
            return EmpName;
        }

        public override double EmployeDetails(double salary)
        {
            Console.WriteLine($"Salary of second employe is {salary}");
            return salary;
        }
    }

    class MainProgram
    {
        static void Main()
        {
            Employeone one = new EmployeeTwo();
            one.EmployeDetails("Dev");
            one.EmployeDetails(45060.5);
            
        }
    }
}