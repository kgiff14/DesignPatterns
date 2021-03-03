using FacadeDemo.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDemo
{
    public class ShapeMaker
    {
        private IShape circle { get; set; }
        private IShape square { get; set; }
        private IShape rectangle { get; set; }

        public ShapeMaker()
        {
            circle = new Circle();
            square = new Square();
            rectangle = new Rectangle();
        }

        public void DrawCircle()
        {
            circle.Draw();
        }

        public void DrawSquare()
        {
            square.Draw();
        }

        public void DrawRectangle()
        {
            rectangle.Draw();
        }
    }
}
