using System;
using System.Collections.Generic;

namespace labs
{
    class Composite
    {
        static void Main(string[] args)
        {
            new Lab10Composite().Run();
        }
    }
    public interface Lab

    {
        void Run();
    }
    class Lab10Composite : Lab
    {
        public void Run()
        {
            // Utworz klasy, niech kazda z nich implementuje interfejs IValuable:
            // - LegoBox
            // - Bricks
            // - RedBrick - wartosc 1 PLN
            // - BlueBrick - wartosc 2 PLN
            // - LegoGuy - wartosc 5 PLN

            // Program po stworzeniu klas powinien wypisac
            // Entire Lego Box costs: 13 PLN

            LegoBox legoBox = new LegoBox(
                new IValuable[] {
                    new Bricks(
                        new IValuable[]{
                            new RedBrick(),
                            new RedBrick(),
                            new BlueBrick(),
                            new BlueBrick(),
                            new BlueBrick()
                        }
                    ),
                    new LegoGuy()
            });
            Console.WriteLine("Entire Lego Box costs: " + legoBox.getValue() + " PLN");
        }
    }

    interface IValuable
    {
        int getValue();
    }

    class RedBrick : IValuable
    {
        public int getValue() => 1;
    }

    class BlueBrick : IValuable
    {
        public int getValue() => 2;
    }

    class LegoGuy : IValuable
    {
        public int getValue() => 5;
    }
    class LegoBox : ValuablesContainer
    {
        public LegoBox(IValuable[] valuables) : base(valuables) { }
    }

    class Bricks : ValuablesContainer
    {
        public Bricks(IValuable[] valuables) : base(valuables) { }
    }

    abstract class ValuablesContainer : IValuable
    {
        protected IValuable[] Elements;

        public ValuablesContainer(IValuable[] valueable)
        {
            Elements = valueable;
        }

        public int getValue()
        {
            int value = 0;
            foreach (IValuable valuable in Elements)
                value += valuable.getValue();
            return value;
        }
    }
}