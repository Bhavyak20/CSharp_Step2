using System;
namespace Company
 {
    /// <summary>
    /// In this code we are using parameters in parent construtor to update data 
    /// so we used base key word in child construvtor to trigger parameters
    /// </summary>
    class Company
       
    {
        public string CompanyName = "TCS";
        public string CompanyLocation = "Chennai";
        public int Companycode;
        public Company(int companycode)//parameters is given in parent costructor so we have to use base key word in child class
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
        public Employe(int companycode) : base(companycode)//here we use base key word to trigger parameters given in parent constructor
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
                Employe emp = new Employe(2901);//heer we used child class to give arguments for parameter
                emp.Message();
                emp.EmployeMessage();
            }
        }
    }
}
