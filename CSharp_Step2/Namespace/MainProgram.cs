


//using EmployeResumes;
using Employe_Expenses;

using System;

namespace MainProgramSystem
{
    class MainProgram
    {
        public static void Main()
        {
            //Word files code
            EmployeResumes.JanFile janfile = new EmployeResumes.JanFile();
            Console.WriteLine(janfile.filename);//heer we used namespace in instance

            //ExcelFiles code
            FebFile febfile = new FebFile();
            Console.WriteLine(febfile.filename); //we used namespace in top of code so no need to use in instance
            JanFile jan_excel = new JanFile();
            Console.WriteLine(jan_excel.filename);

            //PPTFiles code
            PPTFiles.MarFiles ppt = new PPTFiles.MarFiles();//heer we used namespace in instance
            Console.WriteLine(ppt.filename);

        }
    }
}

