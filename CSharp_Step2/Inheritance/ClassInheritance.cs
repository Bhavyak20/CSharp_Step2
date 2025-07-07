
using System;
using System.Security.Policy;

namespace Family

{
    /// <summary>
    /// This code is about inheritance from parent class to child class.
    /// here we didn't used paramertrs in the code.
    /// </summary>
    class Father

    {
        public string fathername { get; set; }
        public string mothername = "Alice";
        public Father()
        {
            fathername = "JOE";//here assigned father name in constructor
            Console.WriteLine("**Father class constructor**");
        }
        public void getMessage()
        {
            Console.WriteLine($"Name of the father is {fathername}");
        }

        class Child : Father//inherited father class
        {
            public string childname = "Ken";
            public Child()
            {
                childname = "Vin";//updated value of childname
                fathername = "Dev";//we can also updat fathername here in child class because of inheritance. 
                Console.WriteLine("Child class constructor");
            }
            public void Message()
            {
                Console.WriteLine($"Name of the child is {childname}");
            }
        }

        class MainProgram
        {
            static void Main()
            {
                // Father father = new Father();
                //father.getMessage();

                Child child = new Child();
                child.getMessage();
                child.Message();


            }
        }


    }
}

