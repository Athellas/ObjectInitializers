using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Init Syntax *****\n");

            // manually setting properties
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            // using custom ctor
            Point anotherPoint = new Point();
            anotherPoint.DisplayStats();

            // init syntax
            Point finalPoint = new Point {X = 30, Y = 30};
            finalPoint.DisplayStats();
            Console.ReadLine();

            Point goldPoint = new Point(PointColor.Gold) { X=90, Y= 20};
            goldPoint.DisplayStats();
            Console.ReadLine();

            // Rectangle part
            Rectangle myRect = new Rectangle
            {
                TopLeft = new Point {X = 10, Y = 10},
                BottomRight = new Point {X = 200, Y = 200}
            };

            myRect.DisplayStats();
            Console.ReadLine();

        }
    }
}
