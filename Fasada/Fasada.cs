// Julia Rutkowska - 12717 - lab4/BEDN , lab4/FEDN  - lab4/BEDN , lab4/FEDN 

using System;
using System.Collections.Generic;

namespace labs
{
    class Facade
    {
        static void Main(string[] args)
        {
            new Lab9Facade().Run();
        }
    }
    public interface Lab

    {
        void Run();
    }
    class Lab9Facade : Lab
    {
        public void Run()
        {
            //buyProduct(new Xbox());
            //sendPackage("United States");
            //new DeliveryPerson().deliverPackage();

            // Zbuduj klasę ConsoleOrderer która zamowi i dostarczy odpowiednią konsolę.
            // Xbox jest wysyłany z USA, a Playstation z Japonii
            // Wyślij na e-wsei klasę ConsoleOrderer

            ConsoleOrderer consoleOrderer = new ConsoleOrderer();
            consoleOrderer.orderPlaystation();
            consoleOrderer.orderXbox(); 
        }

        class ConsoleOrderer
        {
            public void orderXbox()
            {
                buyProduct(new Xbox());
                sendPackage("USA");
                new DeliveryPerson().deliverPackage();

            }

            public void orderPlaystation()
            {
                buyProduct(new Playstation());
                sendPackage("Japan");
                new DeliveryPerson().deliverPackage();
            }

            void buyProduct(IProduct product)
            {
                Console.WriteLine("Buying " + product.getName());
            }
            void sendPackage(String countryOfOrigin)
            {
                Console.WriteLine("Sending Package from: " + countryOfOrigin);
            }

            interface IProduct
            {
                String getName();
            }

            class Playstation : IProduct
            {
                public String getName() => "Playstation";
            }

            class Xbox : IProduct
            {
                public String getName() => "Xbox";
            }

            class DeliveryPerson
            {
                public void deliverPackage()
                {
                    Console.WriteLine("Package has been delivered!");
                }
            }
        }
    }
}