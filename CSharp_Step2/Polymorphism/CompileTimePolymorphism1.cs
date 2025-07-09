using System;
namespace CompileTimePolymorphism
{
    /// <summary>
    /// this is one of the type in polymorphism
    /// in compile-time poly we overload the methods
    /// overload means rewrite methods with different datatypes and parameters but same return type
    /// </summary>
    public class SalaryCalculator
    {
        
        public double Salarycalculator(double monthlysalary)
        {
            return monthlysalary;
        }
        public int Salarycalculator(int monthlysalary)
        {
            return monthlysalary;
        }
        public double Salarycalculator(int montlysalary,double hoursworked)
        {
            return montlysalary *hoursworked;
        }
        public string Salarycalculator(string montlysalary)
        {
            return montlysalary;
        }
        
    }

    class MainProgram
    {
        static void Main()
        {
            SalaryCalculator calculator=new SalaryCalculator();
            double salary1=calculator.Salarycalculator(10000.0);
            int salary2=calculator.Salarycalculator(40000);
           string salary3=calculator.Salarycalculator("35400");
           double salary4= calculator.Salarycalculator(50000, 9.5);
            Console.WriteLine($"This is salary using double DataType{salary1}");
            Console.WriteLine($"This is salary using int DataType{salary2}");
            Console.WriteLine($"This is salary using string DataType{salary3}");
            Console.WriteLine($"This is salary using double DataType using two paarmetrs{salary4}");
        }
    }
}
