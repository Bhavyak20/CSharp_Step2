using System;
class LoopinGDemo
{
    static void Main()
    {                             
        string[] EmployeNames = { "Dev", "Vin", "Raj", "Adi" };
        //                             0     1       2     3 
        int[] EmployeIds = { 911, 912, 913, 914 };
        int[] EmployeSalary = { 45000, 43000, 50000, 48000 };
        string[] EmployeLocation = { "Bgl", "Hyd", "Che", "Viz" };

        for  (int emp = 0; emp < EmployeNames.Length; emp = emp + 1)
        {
            Console.WriteLine($"Name of Employees {EmployeNames[emp]} at index place {emp}: ");
            Console.WriteLine($"Location of {EmployeNames[emp]} is {EmployeLocation[emp]}.");
            EmployeSalary[emp] = EmployeSalary[emp]+10000;
            Console.WriteLine($"Salary of {EmployeNames[emp]} is {EmployeSalary[emp]} and their Id's are {EmployeIds[emp]}.");
        }


        foreach (string employe in EmployeNames)
        {
            Console.WriteLine($"Printing Names of Employes by using foreach {employe}");

            //Console.WriteLine($"Location of {employe} is {EmployeLocation[employe]}");
        } //in 24 line it will throw error because the index we used is for EmployeNames only.
          //but we can make it work in for loop.
    
    }
}