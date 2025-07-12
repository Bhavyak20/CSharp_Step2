using System;
namespace AbstractPractice
{
    abstract class Teamone
    {
        public string TeamName = "Sunrisers Hyderabad";
        public int TeamWins = 2;
        public string SrhCaptain {  get; set; }

        public  Teamone(string Opener1,string Operner2)
        {
            Console.WriteLine($"{Opener1} is from Australia.{Operner2} is from India");
        }
        public abstract void TeamDetails(string Captain,string Franchise,int Wins);
        public void CaptainDetails()
        {
            Console.WriteLine($"Captain is from Australia.");
        }
        
    }

    class Ipl : Teamone
    {
        public Ipl(string Opener1, string Operner2):base( Opener1, Operner2)
        {
            Console.WriteLine("Indian Opener for srh team is: " +Operner2);
        }
        public override void TeamDetails(string Captain, string Franchise, int Wins)
        {
            SrhCaptain = Captain;
            Console.WriteLine($"{TeamName} belongs to {Franchise} and they won total{Wins} Trophies.");
        }
    }
    class MainProgram
    {
        static void Main()
        {
            Teamone srh = new Ipl("Head","Abhishek");
            srh.TeamDetails("PatCummins", "Hyderabad", 2);
            srh.CaptainDetails();
            Console.WriteLine($"{srh.SrhCaptain} is Captain for {srh.TeamName}.");

        }
    }

}
