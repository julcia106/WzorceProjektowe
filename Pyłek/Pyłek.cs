using System;
using System.Collections.Generic;

namespace labs
{
    class Flyweight
    {
        static void Main(string[] args)
        {
            new Lab12Flyweight().Run();
        }
    }
    public interface Lab
    {
        void Run();
    }
    class Lab12Flyweight : Lab
    {
        public void Run()
        {
            // Flyweight
            // Obecny kod za każdym razem ładuje/tworzy obiekt typu Appereance.
            // Jest to bardzo czasochłonne, jedna inicjalizacja trwa aż 1 sekundę.
            // Przy 100 obiektach to prawie 2 minuty, a przy milionie...
            // Proszę przerobić poniższy kod, aby wykorzystał wzorzec Pyłek
            // Utworzyć należy klasy Flyweight oraz FlyweightFactory.
            // Factory ma za zadanie zwrócić obiekt, jeśli był wcześniej skonstruowany.
            // Jeśli nie utworzyć nowy i przechować.
            // Zakładajac, że mamy 3 kolory i 3 rozmiary na konsoli nie powinno wypisaź się więcej niż 9 razy: Loading asset - it takes 1 second
            // W tym zadaniu MOŻNA i NALEŻY modyfikować niektore klasy, jak i wnętrze funkcji Run()
            //
            // Na e.wsei wrzucamy dwie klasy Flyweight oraz FlyweightFactory

            for (int i = 0; i < 100; i++)
            {
                Color randomColor = RandomEnumValue<Color>();
                Size randomSize = RandomEnumValue<Size>();

                Appereance appereance = new Appereance(randomColor, randomSize);
                new ChristmasTreeBall(new Random().Next(1000), new Random().Next(1000), appereance).Display();
            }
        }

        public class Flyweight
        {
            public object Obj { get; private set; }

            public Flyweight(object obj)
            {
                Obj = obj;
            }
        }

        public class FlyweightFactory<T>
        {
            private Dictionary<string, flyweigh> flyweights = new Dictionary<string, Flyweight>();

            public T GetAppereance(Color color, Size size)
            {
                string key = GetAppereance(color, size);

                if (!flyweights.ContainsKey(key))
                {
                    flyweights.Add(key, new Flyweight(new Appereance(color, size)));
                }

                return (T)flyweights[key].CacheBoject;
            }

            private String GetAppereanceKey(Color color, Size size) => $"{color}_{size}";
        }

        public class ChristmasTreeBall
        {
            int x;
            int y;
            Appereance appereance;

            public ChristmasTreeBall(int x, int y, Appereance appereance)
            {
                this.x = x;
                this.y = y;
                this.appereance = appereance;
            }

            public void Display()
            {
                Console.WriteLine($"Drawing {appereance.Draw()} at {x}, {y}");
            }
        }

        public class Appereance
        {
            Color color;
            Size size;
            public Appereance(Color color, Size size)
            {
                this.color = color;
                this.size = size;
                Console.WriteLine("Loading asset - it takes 1 second");
            }

            public String Draw()
            {
                return size + " " + color;
            }
        }

        public enum Size
        {
            Small,
            Medium,
            Large
        }

        public enum Color
        {
            Red,
            Green,
            Blue
        }

        static T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(new Random().Next(v.Length));
        }
    }
}