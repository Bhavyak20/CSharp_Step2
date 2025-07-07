using System;
/// <summary>
/// static class will only contains static members, it will not allow nonstatic members.
/// even constructors should be static -->methods,fields also should be static;
/// we can write return types as well but that also should be in static
/// </summary>

static class ProgramStatic
{
    public static string Myfirstname = "Bhavya";
    public static string MyId = "123";
    static string Mysecondname { get; set; }

    static ProgramStatic()
    {
        Mysecondname = "Sri";
    }
     static void Main()
    {
        Console.WriteLine(Myfirstname);
        Console.WriteLine(Mysecondname);
        Main3();
    }

    public static void Main2()
    {
        Console.WriteLine("My second name is " + Mysecondname);
    }

    public static void Main3()
    {
        Console.WriteLine("My first name is " + Myfirstname);

        Main2();
        Main4("BhavyaSri");
    }

     static string Main4(string FullName)
    {
        Console.WriteLine($"My full name is {FullName}");
        return MyId;
    }
}