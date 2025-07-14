using System;
namespace RuntimPolyPrcatice
{
    class Employeone
    {
        public virtual string EmployeDetails(string Emp1Name)
        {
            Console.WriteLine($"Name of the first Employe is {Emp1Name}.");
            return Emp1Name;
        }
        public virtual double EmployeDetails(double salary)
        {
            Console.WriteLine($"Salary of first Employe is {salary}");
            return salary;

        }
    }

    class EmployeeTwo:Employeone
    {

        public override string EmployeDetails(string Emp2Name)
        {
            Console.WriteLine($" Name of the second employee is {Emp2Name}.");
            return Emp2Name;
        }

        public override double EmployeDetails(double emp2salary)
        {
            Console.WriteLine($"Salary of second employe is {emp2salary}");
            return emp2salary;
        }
    }

    class MainProgram
    {
        static void Main()
        {
            Employeone one = new Employeone();
            one.EmployeDetails("RAJ");
            one.EmployeDetails(44000.80);
            Employeone two = new EmployeeTwo();
            
            two.EmployeDetails("Dev");
            two.EmployeDetails(45060.5);
            
        }
    }
}