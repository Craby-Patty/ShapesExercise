using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Widget[] drawingOfWidgets = new Widget[5];
            drawingOfWidgets[0] = new Rectangle(10,10,30,40);
            drawingOfWidgets[1] = new Square(15, 30, 35);
            drawingOfWidgets[2] = new Ellipse(100, 150, 300, 200);
            drawingOfWidgets[3] = new Circle(1,1,300);
            drawingOfWidgets[4] = new TextBox(5, 5, 200,100,"sample text");
            Print(drawingOfWidgets);
        }


        static void Print(Widget[] drawing)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Requested Drawing");
            Console.WriteLine("----------------------------------------------------------------");
            foreach (var shape in drawing)
            {
                Console.WriteLine(shape);
            }            
            Console.WriteLine("----------------------------------------------------------------");
            Console.ReadKey();
        }


    }
}
