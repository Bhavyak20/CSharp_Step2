using System;
namespace RunTimePolymorphism
{
    /// <summary>
    /// In runtime polymorphism we ovverride the methods using inheritance
    /// key words are virtual and override.
    /// </summary>
    class Employe
    {
        public string Name { get; set; }
        public int EmpId = 9190;
        public double HoursWorked {  get; set; }
        public int HourlyRate {  get; set; }
        public virtual double CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }
        public void GetMessage()
        {
            Console.WriteLine($"Name of the employe is {Name}");
            Console.WriteLine($"EmployeId of {Name} is {EmpId}");
        }
    }

    class PermanentJob :Employe
    {
        public override double CalculateSalary() 
        {
            double baseSalary = HoursWorked * HourlyRate;
            double bonus = baseSalary * 0.2;
            
            return baseSalary + bonus;
        }
    }
    class TemporaryJob:Employe
    {
        public override double CalculateSalary()
        {
           double baseSalary=HoursWorked * HourlyRate;
            double deductions = baseSalary * 0.1;
            return baseSalary*deductions;
        }
    }

    class MainProgram
    {
        static void Main()
        {
            Employe employe = new Employe();
            employe.HoursWorked = 9;
            employe.HourlyRate = 1000;
            employe.Name = "Raj";
            employe.GetMessage();
            double MainSalary = employe.CalculateSalary();
            Console.WriteLine($"Main salary package is {MainSalary}");

            Employe Pemp = new PermanentJob();
            Pemp.HoursWorked = 9;
            Pemp.HourlyRate = 1000;
            Pemp.Name = "DEV";
            double PermanentEMPSALARY =Pemp.CalculateSalary();
            Console.WriteLine($"Salary of Permanent employe is {PermanentEMPSALARY}");

            Employe Temp=new TemporaryJob();
            Temp.HoursWorked = 9;
            Temp.HourlyRate = 1000;
            Temp.Name = "VIN";
           double SalaryOfTempJob= Temp.CalculateSalary();
            Console.WriteLine($"Salary of temporary Employe is {SalaryOfTempJob}");
            
        }
    }
}
