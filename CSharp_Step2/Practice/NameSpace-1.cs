using System;
namespace Employe1
{
    class EMPOneDetails
    {
        public string Emp1Name = "Divya";
        public int Emp1Age = 25;
        public bool Emp1Experienced {  get; set; }
        public string Emp1Location = "Chennai";
        public string Emp1Company;
        public EMPOneDetails(bool Emp1Experience,string Company)
        {
            Emp1Experienced= Emp1Experience;
            Emp1Company= Company;
        }

        static void Main()
        {
            EMPOneDetails emp1=new EMPOneDetails(true,"DXC");
            Console.WriteLine($"{emp1.Emp1Name} is working in {emp1.Emp1Company} from {emp1.Emp1Location}.");
        }
    }
}
