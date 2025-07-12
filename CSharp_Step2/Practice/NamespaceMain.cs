using System;
using ClassPractice;
namespace PrcaticeNamespace
{
    class Namespace
    {
        /// <summary>
        /// Namespace:By using namepsace we can accessfields methods properties and other members from other code by using "using namespace"
        /// 
        /// </summary>
        static void Main()
        {
            Practiceone practice = new Practiceone("Raj",20);

            practice.CollegeName = "VELLORE VIT";//assigned value here because CollegeName is property in Practiceone program
           
            Console.WriteLine($"Name:{practice.Myname} and age:{practice.Age} and Studying is:{practice.StudyYear} year in {practice.CollegeName}.");

            Employe1.EMPOneDetails emp = new Employe1.EMPOneDetails(true,"TCS");
            Console.WriteLine($"{practice.Myname} after graduating from {practice.CollegeName} he joined in {emp.Emp1Company}. since 4 years he is working in IT, now his age is {emp.Emp1Age}.");


        }
    }
}