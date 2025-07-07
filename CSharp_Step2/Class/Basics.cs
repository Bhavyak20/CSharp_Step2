using System;

/// <summary>
/// Class is fundamental bulding block which have multiple members in one block 
/// Memebers:1.Fields 2.Mthods 3.Properties 4.Constructors 4.Delegates
/// </summary>
class FileDetails
{
    //fields:Is a variables.Represents the data that an object of the class can hold.

    string fileName = "Bhavya_Resume.doc";
    string filePages = "4";
    string fileLocation = @"D:\\Documents";
    string fileSize = "2kb";
    string fileCreatedDate = "May-01-2025";
    DateTime createdDateTime = DateTime.Now;


    void ShowDetails(string Name,string size)//one
    {
        Console.WriteLine($"{this.fileName} is having total {this.fileSize} of size");
    }

    static void FileLocationDetails(string name, string location)//two
    {
        Console.WriteLine($"{name} is located in {location} ");
    }

    static void FileDate(string name,string date)
    {
        Console.WriteLine($"{name} is created on {date} *********");//three
    }
    static void Filepges(string filename,string numofPages)
    {
        Console.WriteLine($"The {filename} is having total {numofPages} *pages*");//four
    }

    static void Main()
    {
        

        FileDetails fileRef = new FileDetails();
        Console.WriteLine($"Name of File before Update: {fileRef.fileName}");
        Console.WriteLine($"Location of File before Update: {fileRef.fileLocation}");
        Console.WriteLine($"Size of File before Update: {fileRef.fileSize}");
        Console.WriteLine($"Created Date of File before Update: {fileRef.fileCreatedDate}");

        Filepges(fileRef.fileName, fileRef.filePages);//four


        fileRef.ShowDetails(fileRef.fileName, fileRef.fileSize);//one.a
        FileLocationDetails(fileRef.fileName, fileRef.fileLocation);//two.a

        Console.WriteLine("***************Updated fields with refernce name*******************");
        fileRef.fileName = "Bhavya_Task.doc";
        fileRef.fileLocation = @"C:\\TaskList";
        fileRef.fileSize = "4kb";
        fileRef.fileCreatedDate = "June-30-2025";
        fileRef.filePages = "6";

        Console.WriteLine($"Name of File after Update: {fileRef.fileName}");
        Console.WriteLine($"Location of File after Update: {fileRef.fileLocation}");
        Console.WriteLine($"Size of File after Update: {fileRef.fileSize}");
        Console.WriteLine($"Created Date of File after Update: {fileRef.fileCreatedDate}");

        fileRef.ShowDetails(fileRef.fileName, fileRef.fileSize);//one.b
        FileLocationDetails(fileRef.fileName, fileRef.fileLocation);//two.b


        FileDetails file1 = new FileDetails();
        file1.fileName = "Bhavya_Documents";
        file1.fileCreatedDate = "July-2-2025";
        FileDate(file1.fileName, file1.fileCreatedDate);//three

    }

    
}