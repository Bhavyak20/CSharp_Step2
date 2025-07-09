using System;
namespace InterfaceInheritanceProgram
{
    interface BMWCar
    {
        void CarBrand();
        void CarPrice();
        string  CarOwner(string name);
    }

    interface AudiCar
    {
        int AudiPrice(int price);
        string AudiCarOwner(string name);
    }

    class Car : BMWCar, AudiCar
    {
        public string AudiCarOwner(string name)
        {
            Console.WriteLine($"Audi car owner name is {name}");
            return name;
        }
        

        public int AudiPrice(int price)
        {
            Console.WriteLine($"Price of the Audi car is {price}");
            return price;
        }

        public void CarBrand()
        {
            Console.WriteLine("Brand name of the car is BMW");
        }

        public string CarOwner(string name)
        {
            Console.WriteLine($"Owner name of the BMW car is {name}");
            return name;
        }

        public void CarPrice()
        {
            Console.WriteLine("Price of the BMW car is 50 lakh");
        }

        
    }

    class MainProgram
    {
        static void Main()
        {
            

            BMWCar bmw = new Car();
            bmw.CarBrand();
            bmw.CarOwner("Raj");
            bmw.CarPrice();

            AudiCar audi = new Car();
            audi.AudiPrice(5000000);
            audi.AudiCarOwner("DEV");
        }
    }
}