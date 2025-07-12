using System;
namespace Inheritance
{
    class CompanyDetails
    {
        /// <summary>
        /// Inheritance:It means to inherit fields, properties and methods from baseclass to derived class
        /// even we can modify the values if the fields are set as public or protected.
        /// </summary>
        public string CompanyName = "TCS";
      public   string CompnayLocation = "Chennai";
        public int companyCode {  get; set; }

       public CompanyDetails(int Code)
        {
            companyCode = Code;
            Console.WriteLine($"This is the CompanyDetails Class Constructor");
        }
    }
    class EmployeDetails: CompanyDetails
    {
         
       public string Empname = "Navya";
        public int EmpId = 9187;

        public EmployeDetails(int Code) : base(Code)
        {
            Console.WriteLine($"This is EmployeDetails Constructor.");
        }
        public  void Employe()
        {
            Console.WriteLine($"{Empname} is working in {CompanyName} and her Location is {CompnayLocation}");
        }
    }

    class MainProgram
    {
        static void Main()
        {
            //CompanyDetails company = new EmployeDetails();
            //company.companyCode = 7651;
            //Console.WriteLine($"")
            EmployeDetails emp=new EmployeDetails(7699);
            //emp.companyCode = 7685;
            emp.Employe();
            Console.WriteLine($"{emp.companyCode} is the Code for {emp.CompanyName}.");

        }
    }
}
