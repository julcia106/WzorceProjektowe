// Julia Rutkowska - 12717 - lab4/BEDN , lab4/FEDN  - lab4/BEDN , lab4/FEDN 

using System;
using System.Collections.Generic;

namespace Adapter
{
    class Adapter
    {
        static void Main(string[] args)
        {
            new Lab8Adapter().Run();
        }
    }
    public interface Lab
    {
        void Run();
    }
    class Lab8Adapter : Lab
    {
        public void Run()
        {
            OldColorPrinter printer = new OldColorPrinter();
            HexColor hexColor = new HexColor("#00ff00", 50);
            printer.printColor(hexColor);
            RgbColor rgbColor = new RgbColor(85, 255, 132);

            // UTWORZ ADAPTER I ODKOMENTUJ PONIZSZY KOD
            // Nazwa klasy adaptera to - RgbOldPrinterAdapter
            // Prosze wyslac tylko klase adaptera na e-wsei
           
            IPrintable adapter = new RgbOldPrinterAdapter(printer);
            adapter.printColor(rgbColor);
        }
    }

    interface IPrintable
    {
        void printColor(RgbColor rgbColor);
    }

    public class RgbColor
    {
        public int red;
        public int green;
        public int blue;

        public RgbColor(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
    }

    public class HexColor
    {
        public String value;
        public int alpha;

        public HexColor(String value, int alpha)
        {
            this.value = value;
            this.alpha = alpha;
        }
    }

    public class OldColorPrinter
    {

        public void printColor(HexColor hexColor)
        {
            Console.WriteLine(hexColor.value + " with alpha: " + hexColor.alpha);
        }
    }

    public class RgbOldPrinterAdapter : IPrintable
    {
        OldColorPrinter Printer { get; set; }
        public RgbOldPrinterAdapter(OldColorPrinter oldColorPrinter)
        {
            oldColorPrinter = Printer;
        }
        public void printColor(RgbColor rgbColor)
        {
            string hexColor = "#" + rgbColor.red.ToString("X2") + rgbColor.green.ToString("X2") + rgbColor.blue.ToString("X2");

            HexColor hex = new HexColor(hexColor, 0);

            this.Printer.printColor(hex);
            Console.WriteLine(hexColor);
        }
    }

}