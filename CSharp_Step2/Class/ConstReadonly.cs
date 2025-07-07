using System;

class ConstReadonly
{
    //const:we use this variable to assign value and be static entire code(it means not change value)
    //when we use const we should defently assign value,we can't leave we=ith empty or null.
    const double Pi = 3.14;
    const string MyName = "Raj";
    //for readonly we can reassign values only in constructors in code.
    readonly string MyCompany = "TCS";
    static readonly string MyLocation = "Banglore";
    readonly int myid=1234;
    public void Method1()
    {
        
        Console.WriteLine(Pi);
    }
    
    public ConstReadonly()
    {
        myid = 987;
        //MyName= MyCompany;//here it will get error because MyName is const,so we can't reassign MyCompany Value

        MyCompany= MyName;//but here we can reassign value for MyCompany with MyName,because we are assigning in constructor.

        Console.WriteLine("My Name is :" +MyCompany);
        myid = 237;
    }

    
    static void Main()
    {
              
       
        Console.WriteLine(Pi);
        

        //Console.WriteLine("Name of my company is:" + MyCompany);
        //beacuase Mycompany is non static and we are using in static void method

        Console.WriteLine("mYOffiice location is: " + MyLocation);
        //here it will get executed because MyLocation is satic readonly and we are using in static void method

    }
    
    }

