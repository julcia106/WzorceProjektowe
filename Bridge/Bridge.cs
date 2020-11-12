// Julia Rutkowska - lab4/BEDN , lab4/FEDN  - lab4/BEDN , lab4/FEDN 

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
            redSquare.draw();
            Shape blueTriangle = new Triangle(new Blue());
            blueTriangle.draw();
        }
    }
}
    }
}
