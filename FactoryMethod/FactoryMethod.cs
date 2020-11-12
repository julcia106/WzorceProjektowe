// Julia Rutkowska- lab4/BEDN , lab4/FEDN  - lab4/BEDN , lab4/FEDN 

//1.Stworz aplikację konsolową dla targów samochodowych implementując wzorzec Factory method.
//2. Konkrenta Fabryka ma zbudować samochód. 
//3. Abstrakcyjna ma metodę do prezentacji samochodu niezależnie od marki oraz zawiera sygnaturę funkcji implementowaną przez konkretne fabryki.
//4. Aplkacja powinna wypisać na konsolę (nie wolno modyfikować kodu startowego):

//Witamy na targach samochodowych

//Witamy na pokazie samochodu marki Bmw
//Teraz zobaczmy jak działają kierunkowskazy
//Kierowcy i tak ich nie uywają, więc w tym modelu nie dodaliśmy kierunkowskazów
//Koniec pokazu


//Witamy na pokazie samochodu marki Skoda
//Teraz zobaczmy jak działają kierunkowskazy
//Zobaczcie pięknie migające migacze
//Koniec pokazu



//Klasy i interfejsy które powinny się znajdować, pomyśl co jest klasą, co interfejsem, a co klasą abstrakcyjną.

//ICar,
//Bmw,
//Skoda,
//CarFactory,
//Skoda Factory,
//BmwFactory

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
    // ToDo Dodaj wlasny kod
}