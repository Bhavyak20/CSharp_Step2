using System;
class Properties
    {
    string filename = "TaskList.Doc";
    string filelocation = @"C:\\Downloads";
    string filesize = "3kb";
    DateTime craetedDateTime= DateTime.Now;

    string FileName { get; set; }    
    string FileLocation { get; set; }
    string FileSize { get; set; }
    
    static void Main()
    {
        Properties properties = new Properties();


        properties.filename = "TaskList_2.Doc";
        properties.FileName = "TaskList_3.Doc";
        properties.FileLocation = @"D:\\Documents";
        properties.FileSize = "3kb";

        Console.WriteLine($"{properties.FileName} size is {properties.FileSize} ");
    }
    }



