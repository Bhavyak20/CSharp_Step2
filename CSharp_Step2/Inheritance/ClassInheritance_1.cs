using System;
using static System.Net.Mime.MediaTypeNames;

namespace ClassInheritanceProgram
{
    class BMWCar
    {
        public string colour = "Blue";
        public string owner = "Raj";
        public int Milage;
        public BMWCar(int milage)
        {
            Milage = milage;
            Console.WriteLine($"This is constructor for BMWCar class");
        }
        public void Getmessage()
        {
            Console.WriteLine($"{owner} bought BMWCar and it's colour is {colour}");
            Console.WriteLine($"BMW car gives {Milage}");
        }
    }

    class AUDICar : BMWCar
    {
        public AUDICar(int milage):base (milage)
        {
            Console.WriteLine($"This is constructor for AUDI class");
            //Console.WriteLine($"Audi car gives {milage}");
        }
        public void MessageGet()
        {
            Console.WriteLine($"{owner} bought Audi car and it's colour is {colour}");
            Console.WriteLine($"Audi car gives {Milage}");
        }
    }

    class MainProgram
    {
        static void Main()
        {
            BMWCar bmw = new BMWCar(100);
            bmw.Getmessage();

            AUDICar audi=new AUDICar(90);
            audi.MessageGet();
        }
    }
}
