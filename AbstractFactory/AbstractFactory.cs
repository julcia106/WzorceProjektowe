// Julia Rutkowska- 12717- lab4/BEDN , lab4/FEDN  - lab4/BEDN , lab4/FEDN 

using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    interface IRoomFactory
    {
        public IChair CreateChair();
        public ISofa CreateSofa();
    }

    class IkeaFactory : IRoomFactory
    {
        public IChair CreateChair()
        {
            return (new MarkusChair());
        }

        public ISofa CreateSofa()
        {
            return (new HemnesSofa());
        }
    }

    interface IFurniture
    {
        public string Show();
    }
    interface IChair : IFurniture
    {

    }
    interface ISofa : IFurniture
    {

    }

    class MarkusChair : IChair
    {
        public string Show()
        {
            return "Markus Chair";
        }
    }

    class HemnesSofa : ISofa
    {
        public string Show()
        {
            return "Hemnes Sofa";
        }
    }
    class AbstractFactory
    {
        static void Main(string[] args)
        {
            new Lab6AbstractFactory().Run();
        }
    }
    public interface Lab

    {
        void Run();
    }
    class Lab6AbstractFactory : Lab
    {
        public void Run()
        {
            Console.WriteLine("Witamy w salonie z meblami");
            ShowRoomProject(new IkeaFactory());
        }
        void ShowRoomProject(IRoomFactory roomFactory)
        {
            Console.WriteLine();
            Console.WriteLine("Budujemy pokoj w stylu " + roomFactory.GetType().Name);
            Console.WriteLine("Pokoj będzię się składał z:");
            IChair chair = roomFactory.CreateChair();
            Console.WriteLine(chair.Show());
            ISofa sofa = roomFactory.CreateSofa();
            Console.WriteLine(sofa.Show());
            Console.WriteLine();
        }
    }
}
