using System;
namespace InterfaceBasics 
{
    interface Interface1 
    {
        int property { get; set; }
        int Method();
        int Method1(string Companyname);
        //int string myname = "Bhavya";//error beacuase interface can't have fields
        string str_Method2(int age);
        string str_Method3(string Job, int Experience);
     }
    
        
}

