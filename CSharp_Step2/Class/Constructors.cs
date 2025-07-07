using System;
 class Constructors
    {
    string fileName = "StudentsList.doc";
    string filesize = "5kb";
    string filelocation = @"C:\\Downloads";
    string fileCreatedDate = "March-27-2025";

    public Constructors()
    {
        Console.WriteLine("First Constructor with printing varaiable values");
        Console.WriteLine(this.fileName);
        Console.WriteLine(this.filesize);

    }
    public Constructors(string subject,string date)
    {
        Console.WriteLine("second constructor in the class with paraameters and updated variable values.");
        Console.WriteLine("The file we have is :" + fileName);

        this.fileName = "SubjectList.doc";//here i have update value
        this.filelocation = @"C:\\subjects\\task";
        // this.fileCreatedDate = date;//it will not execute because filecreatedDate is string and date is int
        this.fileCreatedDate = date;
        this.fileName = subject;//here i have assigned fileName to subject(parameter)

        Console.WriteLine(this.fileName);
        Console.WriteLine(this.filesize);
        Console.WriteLine(this.filelocation);
        Console.WriteLine(this.fileCreatedDate);
    }

    
    public Constructors(string firstname, int num,string secondname)
    {
        //firstname = "Bhavya";
        num = 1234;
        secondname = "sri";
        Console.WriteLine("Third constructor in the class with Parameters " +firstname);
        Console.WriteLine("Third constructor in the class with Parameters " + secondname);
        Console.WriteLine("The file we have is :" + filelocation);
    }

    static void Main()
    {
        Constructors c = new Constructors();
        Constructors file1 = new Constructors("Maths","12/12/2024");
        file1.fileName = "TeachersList.Doc";
        //Console.WriteLine("File name after Update using instance "+file1.fileName);

        Constructors file2 = new Constructors("Navya",123,"Sai");
    }


    }

