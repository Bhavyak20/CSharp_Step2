using System;

namespace ClassPractice
{
    class Practiceone
    {
        /// <summary>
        /// These are fields that we write in class.
        /// </summary>
        public string Myname = "Dev";
        public int Age = 19;      
        public string CollegeName { get; set; }
        public string BranchName {  get; set; }
        public int StudyYear = 3;

        public Practiceone(string name, int age)
        {
            Myname = name;//reassigned field to parameter.
            //We can create num of constructors for class 
            //we can't assign return type or static not even void for constructor.
            //By using constructors we can reassign values of fields with using object refernce in Main()
            Console.WriteLine($"This is the First constructor");
        }
    }

    class MainProgram
    {
        static void Main()
        {
            Practiceone practiceone = new Practiceone("Raj", 20);

            practiceone.Myname = "VIN";
            practiceone.CollegeName = "VIT";
            practiceone.BranchName = "ECE";

            Console.WriteLine($"Name of th studnet is {practiceone.Myname} \n age is {practiceone.Age}.");
            //in above lien we will get Raj and 19 .why 19 because we didn't reassigned Age to param in constructor.
            
        }
    }
}