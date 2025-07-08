using System;
namespace VehicleConfiguration
{
    abstract class Vehicle
    {
        public string FuelType { get; set; }
        public int Capacity { get; set; }
        public abstract void Start();//abstract method(unimplemented)
        public abstract void Stop();//abstract method(unimplemented)
        public abstract void Engine();//abstract method(unimplemented)

        //concrete method(implemented)
        public void ShowDetails()
        {
            Console.WriteLine($"The fuel type we ar eusing in vehicle is {FuelType}");
            Console.WriteLine($"The Capacity of the vehicle is {Capacity}");
        }
    }
    //Derived class or child class
    class Car : Vehicle
    {
        public override void Engine()//while implememting abstartc class method we should use override key word.
        {
            Console.WriteLine("Car engine is a 4-cylinder petrol engine.");
        }

        public override void Start()
        {
            Console.WriteLine("Car has started .");
        }

        public override void Stop()
        {
            Console.WriteLine("Car has stopped .");
        }
    }

    class Bike : Vehicle
    {
        public override void Engine()//while implememting abstartc class method we should use override key word.
        {
            Console.WriteLine("Bike engine is a 1 or 2-cylinder petrol engine.");
        }

        public override void Start()
        {
            Console.WriteLine("Bike has started .");
        }

        public override void Stop()
        {
            Console.WriteLine("Bike has stopped .");
        }
    }



    class MainProgram
    {
         static void Main()
            {
                Vehicle vehicle = new Car();
                vehicle.FuelType = "Petrol";
                vehicle.Capacity = 100;
                vehicle.ShowDetails();




                Car car = new Car();
                car.Start();
                car.Stop();
                car.Engine();


            Bike bike = new Bike();
            bike.Start();
            bike.Stop();
            bike.Engine();
            }
        }
    }
