// Julia Rutkowska - 12717 - lab4/BEDN , lab4/FEDN  - lab4/BEDN , lab4/FEDN 

using System;
using System.Collections.Generic;

namespace Bridge
{
    class Bridge
    {
        static void Main(string[] args)
        {
            new Lab7Bridge().Run();
        }
    }
    public interface Lab

    {
        void Run();
    }
    class Lab7Bridge : Lab
    {
        public void Run()
        {
            Shape redSquare = new Square(new Red());
            redSquare.Draw();
            Shape blueTriangle = new Triangle(new Blue());
            blueTriangle.Draw();
        }

        abstract class Shape
        {
            protected IColor color;
            public Shape (IColor color)
            {
                this.color = color;
            }

            protected abstract String GetShapeName();

            public void Draw()
            {
                Console.WriteLine(color.GetName() + " " + GetShapeName());
            }
        }

        class Square : Shape
        {
            public Square(IColor color) : base(color)
            {

            }
            protected override String GetShapeName()
            {
                return "Square";
            }
        }
         
        class Triangle : Shape
        {
            public Triangle (IColor color) : base(color)
            {

            }

            protected override String GetShapeName()
            {
                return "Triangle";
            }
        }

        interface IColor
        {
            public String GetName();
        }

        class Red : IColor
        {
            public String GetName()
            {
                return "Red";
            }

        }

        class Blue : IColor
        {
            public String GetName()
            {
                return "Blue"; 
            }
        }
    }
}
