// Julia Rutkowska- lab4/BEDN , lab4/FEDN  - lab4/BEDN , lab4/FEDN 

using System;
using System.Collections.Generic;

namespace labs
{
    class Prototype
    {
        static void Main(string[] args)
        {
            new Lab3Prototype().Run();
        }
    }
    public interface Lab

    {
        void Run();
    }

    class Lab3Prototype : Lab
    {
        public void Run()
        {
            Author adam = new UpdateAuthor("Adam Mickiewicz", "Polska", "Polski");
            Author juliusz = new UpdateAuthor("Juliusz Slowacki", "Polska", "Polski");

            Author AdamAfterMigration = adam.Clone();
            AdamAfterMigration.country = "Francja";
            adam.sayHello();
            juliusz.sayHello();

            AdamAfterMigration.sayHello();

        }
    }

    abstract class Author
    {
        public string name;
        public string country;

        public Author(string name, string country)
        {
            this.name = name;
            this.country = country;
        }

        public void sayHello()
        {
            Console.WriteLine("Jestem " + name + ". Moj kraj w ktorym przebywam to " + country);
        }
        public abstract Author Clone();
    }

    class UpdateAuthor : Author
    {
        public string language;
            
        public UpdateAuthor (string name, string country, string language) : base(name, country)
        {
            this.language = language;
        }

        public override Author Clone()
        {
            return new UpdateAuthor(name, country, language);
        }
    }
}