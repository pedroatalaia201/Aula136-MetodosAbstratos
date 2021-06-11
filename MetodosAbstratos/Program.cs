using System;
using System.Globalization;
using System.Collections.Generic;
using MetodosAbstratos.Entities;
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numb = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numb; i++)
            {
                Console.WriteLine($"Enter the #{i} shape data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char shp = char.Parse(Console.ReadLine());

                Console.Write("Color (Black, Red, Blue)? ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(shp == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(color, width, height));
                }

                else
                {
                    Console.Write("Radius: ");
                    double rad = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Circle(color, rad));
                }
            }

            Console.WriteLine("\nShape Areas:");

            foreach(Shape form in shapes)
            {
                Console.WriteLine(form.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
