using System;
namespace RemotingSystem
{
    interface Iremote
    {
        void PowerOn();
        void PowerOff();
        void ChangeChannel(int channelNum);
        void IncreaseVolume();
    }
    interface RemotePrice
    {
        string GetPriceDetails(string price);//here i have given price as parameter and method is nonvoid(Means return type)
    }
    interface RemoteLocation
    {
        string GetLocationDetails();//here i didn't gave any parameter but it is non void(return type)
    }
    class SonyRemote : Iremote, RemotePrice
    {
        void Iremote.ChangeChannel(int channelNum)
        {
            Console.WriteLine($" SonyTv Change channel to {channelNum}");
        }

        void Iremote.IncreaseVolume()
        {
            Console.WriteLine("Sony TV Incraese Volume");
        }

        void Iremote.PowerOff()
        {
            Console.WriteLine("Sony TV Power Off now");
        }

        void Iremote.PowerOn()
        {
            Console.WriteLine("Sony TV Power ON now");
        }
        string RemotePrice.GetPriceDetails(string price )
        {
            Console.WriteLine($" Price of remote is {price}");
            return price;
            
        }
    }
    class LGRemote : Iremote, RemoteLocation
    {
        void Iremote.ChangeChannel(int channelNum)
        {
            Console.WriteLine($" LG TV Change channel to {channelNum}");
        }

        void Iremote.IncreaseVolume()
        {
            Console.WriteLine("LG TV Incraese Volume");
        }

        void Iremote.PowerOff()
        {
            Console.WriteLine("LG TV Power OFF now");
        }

        void Iremote.PowerOn()
        {
            Console.WriteLine("LG TV Power ON now");
        }

        string RemoteLocation.GetLocationDetails()
        {
            
            return "Banglore";
        }
    }

    class MainProgram
    {
        static void Main()
        {
            Iremote remote = new SonyRemote();
            remote.PowerOn();
            remote.ChangeChannel(9);
            remote.IncreaseVolume();
            remote.PowerOff();

            RemotePrice remoteprice = new SonyRemote();
           remoteprice.GetPriceDetails("200");


            Iremote lgremote = new LGRemote();
            lgremote.PowerOn();
            lgremote.ChangeChannel(3);
            lgremote.IncreaseVolume();
            lgremote.PowerOff();

            RemoteLocation lgremotelocation = new LGRemote();
            string Location=lgremotelocation.GetLocationDetails();
            Console.WriteLine("Location is: "+Location);
        }
    }
}
