using System;
class FieldsandMethods
    {
    string studentname = "Raj";
    string schoolname = "GreenDale";
    string schoollocation = "Vizag";
    string studentgrade = "PP1";

    void SchoolDetails(string studentname,string schoolname)
    {
        Console.WriteLine($"{this.studentname} is studying in {this.schoolname}");
    }

    static void SchoolLocation(string schoolname,string schoollocation)
    {
        Console.WriteLine($"{schoolname} is located in {schoollocation}");
    }

    static void StudentGradeDetails(FieldsandMethods fm)
    {
        Console.WriteLine($"{fm.studentname} is currently studying {fm.studentgrade}");
    }
    static void Main()
    {
        FieldsandMethods fields = new FieldsandMethods();
        fields.schoolname = "Euro kids";
        fields.SchoolDetails(fields.studentname, fields.schoolname);

        SchoolLocation(fields.schoolname,fields.schoollocation);

        FieldsandMethods methods = new FieldsandMethods();//single statement
        {
            methods.studentname = "Vin";
            methods.studentgrade = "9th";
        }
        StudentGradeDetails(methods);
    }

    }
