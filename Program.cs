using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_1__Classes_and_Objects_.Task_2;
using Lesson_1__Classes_and_Objects_.Task_3;
using Lesson_1__Classes_and_Objects_.Task_4;

namespace Lesson_1__Classes_and_Objects_
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // Additional Task

            //-----------------------------------------------------------------------------------

            //var address = new Address(98669, "USA", "LA", "Miami Beach", 43, 123);
            //address.ShowAddress();

            //-----------------------------------------------------------------------------------

            // Task 2

            //-----------------------------------------------------------------------------------

            //var rect = new Rectangle(10.6, 11.5);

            //Console.WriteLine(rect.AreaOfRectangle());
            //Console.WriteLine(rect.PerimeterOfRectangle());

            //-----------------------------------------------------------------------------------

            // Task 3

            //-----------------------------------------------------------------------------------

            //var book = new Book(new Tittle("C# 9.0 .NET 5"), 
            //    new Author("Troelsen"), new Content("Examples and Explanations"));

            //book.ShowDate();

            //-----------------------------------------------------------------------------------

            // Task 4

            //-----------------------------------------------------------------------------------

            Figure figure = new Figure(new Point(1, 1, type: "A"), new Point(1, 1, type: "B"), new Point(1, 4, "C"));

            Console.WriteLine($"{0}, P = {figure.Type}");

            figure.PerimeterCalculator();

            //-----------------------------------------------------------------------------------
        }
    }
}
