using System;
using System.Collections.Generic;

namespace labs
{

    class Decorator
    {
        static void Main(string[] args)
        {
            new Lab11Decorator().Run();
        }
    }
    public interface Lab

    {
        void Run();
    }
    class Lab11Decorator : Lab
    {
        public void Run()
        {

            // Decorator
            // 1. Stwórz klasy BoldTextDecorator oraz ItalicTextDecorator
            // 2. Dzięki zastosowaniu dekoratorów na konsoli powinno pojawić się:
            // <i><b>Szare Renifery</b></i>
            // 3. Prześlij na e.wsei tylko Twoje 2 klasy.

            ConcreteTextComponent concreteTextEditor = new ConcreteTextComponent("Szare Renifery");
            BoldTextDecorator boldTextDecorator = new BoldTextDecorator(concreteTextEditor);
            ItalicTextDecorator italicTextDecorator = new ItalicTextDecorator(boldTextDecorator);
            Console.WriteLine(italicTextDecorator.apply());
        }
    }

    public abstract class TextComponent
    {
        public abstract String apply();
    }

    public class ConcreteTextComponent : TextComponent
    {
        private String text;

        public ConcreteTextComponent(String text)
        {
            this.text = text;
        }

        public override String apply()
        {
            return this.text;
        }
    }

    public abstract class TextDecorator : TextComponent
    {
        protected TextComponent component;

        public TextDecorator(TextComponent component)
        {
            this.component = component;
        }

        public override String apply()
        {
            return component.apply();
        }
    }

    public class BoldTextDecorator : TextDecorator
    {
        public BoldTextDecorator(TextComponent component) : base(component) { }

        public override string apply() => "<b>" + base.apply() + "<b>";
    }

    public class ItalicTextDecorator : TextDecorator
    {
        public ItalicTextDecorator(TextComponent component) : base(component) { }

        public override string apply() => "<i>" + base.apply() + "<i>";
    }
}