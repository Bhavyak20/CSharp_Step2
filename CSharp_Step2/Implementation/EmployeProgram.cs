using System;
namespace EmployeProgram
{
    interface CompanyDetails//interface-1
    {
        string CompanyName();//non-voidmethod
        void CompanyLocation(string Location);//void method with param
        void CompanyType();//void method
    }
    interface ProjectDetails//interface-2
    {
        string Projecttype();//non void method
        void ProjectName();//void method
        int MembersinTeam(int teamNum);//non void method with param
    }


    class Employe : CompanyDetails, ProjectDetails//class one

    {
        public string Employename = "Raj";//fields used in class 
        string CompanyDetails.CompanyName()
        {
            
            return "TCS";
        }


        void CompanyDetails.CompanyLocation(string Location)
        {
            Console.WriteLine($"Employe Working in TCS and location is {Location}");
        }

        void CompanyDetails.CompanyType()
        {
            Console.WriteLine($" TCS is Service based company");
        }

        int ProjectDetails.MembersinTeam(int teamNum)
        {
            Console.WriteLine($"Total there are {teamNum} members in team");
            return teamNum;
        }

        void ProjectDetails.ProjectName()
        {
            Console.WriteLine("Name of the project is abcdf");
        }

        string ProjectDetails.Projecttype()
        {
            Console.WriteLine($"{Employename} is working in TCS");
            return "Develop";
        }
    }

    class MainProgram
    {
        static void Main()
        {
            CompanyDetails compDets = new Employe();
            compDets.CompanyLocation("Chennai");
            compDets.CompanyType();
           string CompName= compDets.CompanyName();
            Console.WriteLine("Name of the company is " +CompName);

            ProjectDetails project = new Employe();
            project.MembersinTeam(12);
            project.ProjectName();
            string typeofproject=project.Projecttype();
            Console.WriteLine(typeofproject);

        }
    }
}
