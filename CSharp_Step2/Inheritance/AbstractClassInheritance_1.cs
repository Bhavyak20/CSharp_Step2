using System;
namespace AbstractClassInheritance
{
    abstract class Car
    {
        public string Carowner = "Vin";
        public abstract void Cardetails(string carbrand,int carprice);

        public abstract void CarColour(string colour);
        public int CarMilage = 120;

        public void Getmessage()
        {
            Console.WriteLine("This is concrete class");
            Console.WriteLine($"{Carowner} is buying new car.");
           
        }
    }

    class Person : Car
    {
        public override void Cardetails(string carbrand, int carprice)
        {
            // throw new NotImplementedException();
            Console.WriteLine($"{Carowner} bought {carbrand} and it's price is {carprice}");
        }
        public override void CarColour(string colour)
        {
            //throw new NotImplementedException();
            Console.WriteLine($"Car Bought by {Carowner} gives {CarMilage} and it's colour is {colour}");
        }

        
    }
    class MainProgram
    {
        static void Main()
        {
            

            Car car = new Person();
            car.Getmessage();
            car.Cardetails("Audi", 5000000);
            car.CarColour("RoyalBlue");
        }
    }
}