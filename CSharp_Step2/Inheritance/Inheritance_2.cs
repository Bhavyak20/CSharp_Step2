using System;
namespace Company

{
    class Company
    {
        public string CompanyName = "TCS";
        public string CompanyLocation = "Chennai";
        public int Companycode;
        public Company(int companycode)
        {
            Companycode = companycode;
            Console.WriteLine("This is company Class constructor");
        }
        public void Message()
        {
            Console.WriteLine($"{CompanyName} is located in {CompanyLocation}.");
        }
    }

    class Employe : Company
    {
        public string EmployeName = "Raj";
        public Employe(int companycode) : base(companycode)
        {
            Console.WriteLine("this is Employe class Constructor");
        }

        public void EmployeMessage()
        {
            Console.WriteLine($"{EmployeName} is working in {CompanyName} at {CompanyLocation} and code is {Companycode}");
        }

        class Program
        {
            static void Main()
            {
                Employe emp = new Employe(2901);
                emp.Message();
                emp.EmployeMessage();
            }
        }
    }
}
