// Julia Rutkowska- lab4/BEDN , lab4/FEDN  - lab4/BEDN , lab4/FEDN 

using System;
using System.Collections.Generic;

namespace AbstractFactory
{

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
            IChair chair = roomFactory.createChair();
            Console.WriteLine(chair.show());
            ISofa sofa = roomFactory.createSofa();
            Console.WriteLine(sofa.show());
            Console.WriteLine();
        }
    }
}
}
