// Julia Rutkowska- 12717- lab4/BEDN , lab4/FEDN  - lab4/BEDN , lab4/FEDN 

//Kod startowy:

using System;
using System.Collections.Generic;

namespace labs
{

    class FactoryMethod
    {
        static void Main(string[] args)
        {
            new Lab5FactoryMethod().Run();
        }
    }
    public interface Lab

    {
        void Run();
    }
    class Lab5FactoryMethod : Lab
    {
        public void Run()
        {
            Console.WriteLine("Witamy na targach samochodowych");
            MakeCarShow(new BmwFactory());
            MakeCarShow(new SkodaFactory());
        }
        void MakeCarShow(CarFactory carFactory)
        {
            carFactory.PresentBrandNewCar();
        }
    }
    interface ICar
    {
        public void ShowTurnSignal();
    }

    abstract class CarFactory
    {
        public abstract ICar FactoryMethodMakeCar();
        public void PresentBrandNewCar()
        {
            ICar car = FactoryMethodMakeCar();
            Console.WriteLine(
                "Witamy na pokazie samochodu marki " + car.GetType().Name + ".\n" +
                "Teraz zobaczmy jak działają kierunkowskazy\n");

            car.ShowTurnSignal(); 

            Console.WriteLine( "Koniec pokazu.\n");
        }
    }
    class BmwFactory : CarFactory
    {
        public override ICar FactoryMethodMakeCar()
        {
            return new Bmw();
        }
    }

    class Bmw : ICar
    {
        public void ShowTurnSignal()
        {
            Console.WriteLine("Kierowcy i tak ich nie uywają, więc w tym modelu nie dodaliśmy kierunkowskazów. ");
        }
    }
    class SkodaFactory : CarFactory
    {
        public override ICar FactoryMethodMakeCar()
        {
            return new Skoda();
        }   
    }
    class Skoda : ICar
    {
        public void ShowTurnSignal()
        {
            Console.WriteLine("Teraz zobaczmy jak działają kierunkowskazy\n" +
                " Zobaczcie pięknie migające migacze");
        }
    }
}

