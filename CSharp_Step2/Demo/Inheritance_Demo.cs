using System;
namespace InheritanceDemo
{
    class CompanyDetails
    {
        /// <summary>
        /// Inheritance:It means to inherit fields, properties and methods from baseclass to derived class
        /// even we can modify the values if the fields are set as public or protected.
        /// </summary>
        public string CompanyName = "TCS";
        public string CompnayLocation = "Chennai";
        public int companyCode { get; set; }

        public CompanyDetails(int CodeofCompany)
        {
            companyCode = CodeofCompany;
            Console.WriteLine($"This is the CompanyDetails Class Constructor");
        }
    }
    class EmployeoneDetails : CompanyDetails
    {

        public string Empname = "Navya";
        public int EmpId = 9187;

        public EmployeoneDetails(int CodeofCompany) : base(CodeofCompany)
        {
            Console.WriteLine($"This is EmployeoneDetails Constructor.");
        }
        public void Employe()
        {
            Console.WriteLine($"{Empname} is working in {CompanyName} and her Location is {CompnayLocation}");
            Console.WriteLine($"{companyCode} is company code for {CompnayLocation} Location office.");
        }
    }
    class EmployetwoDetails : CompanyDetails
    {

        public string Emptwoname = "Lasya";
        public int EmptwoId = 9100;

        public EmployetwoDetails(int Code) : base(Code)
        {
            Console.WriteLine($"This is EmployetwoDetails Constructor.");
        }
        public void Employe()
        {
            CompnayLocation = "Banglore";//I have changed location from base class
            Console.WriteLine($"{Emptwoname} is working in {CompanyName} and her Location is {CompnayLocation}");
            Console.WriteLine($"{Emptwoname} is working from {CompnayLocation} so teh code for that location is {companyCode}.");
        }
    }

    class MainProgram
    {
        static void Main()
        {
            //first derived class calling
            EmployeoneDetails emp = new EmployeoneDetails(7699);
            emp.Employe();

            //Second derived class calling
            EmployetwoDetails empTwo = new EmployetwoDetails(7600);
            empTwo.Employe();


        }
    }
}
