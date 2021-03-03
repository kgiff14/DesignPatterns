using FlyweightDemo.Shapes;
using System;

namespace FlyweightDemo
{
    class FlyweightPattern
    {
        private static string[] colors = { "Red", "Green", "Blue", "White", "Black" };
        private static Random random = new Random();
        public static void Main(string[] args)
        {
            for(int i=0; i < 20; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetCircle(getRandomColor());
                circle.SetX(getRandomX());
                circle.SetY(getRandomY());
                circle.SetRadius(100);
                circle.Draw();
            }
        }

        private static string getRandomColor()
        {
            return colors[random.Next(0, 4)];
        }

        private static int getRandomX()
        {
            return random.Next(1, 100);
        }

        private static int getRandomY()
        {
            return random.Next(1, 100);
        }
    }
}
