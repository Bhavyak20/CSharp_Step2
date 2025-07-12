using System;
using System.Security.Cryptography;
namespace PolymorphismPractice
{
class One
    {
        public string MyDetails(string name)
        {
            Console.WriteLine($"My name is {name}");
            return name;
        }
        public int MyDetails(int age)
        {
            Console.WriteLine($"My age is {age}");
            return age;
        }
        public double  MyDetails(double Salary)
        {
            Console.WriteLine($"I'm earning {Salary}.");
            return Salary;
        }
    }

    class Two
    {
        public string MovieDetails(string mvName)
        {
            Console.WriteLine($"My favorite movie is {mvName}");
            return mvName;
        }
        public double MovieDetails(double mvDuration)
        {
            Console.WriteLine($"Duration of the movie is {mvDuration} hours");
            return mvDuration;
        }
        public  void MovieDetails()
        {
            Console.WriteLine("Movie Details.");
        }
    }

    class MainProgram
    {


        static void Main()
        {
            One one = new One();
            one.MyDetails("Raj");
            one.MyDetails(23);
            one.MyDetails(55000.4);

            Two two = new Two();
            two.MovieDetails("abc");
            two.MovieDetails(2.00);
            two.MovieDetails();


        }
    }
}