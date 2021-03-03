using FlyweightDemo.Shapes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDemo
{
    public class ShapeFactory
    {
        private static Hashtable circleHash = new Hashtable();

        public static IShape GetCircle(string color)
        {
            Circle circle = (Circle)circleHash[color];

            if(circle == null)
            {
                circle = new Circle(color);
                circleHash.Add(color, circle);
                Console.WriteLine("Creating circle of color: " + color);
            }
            return circle;
        }
    }
}
