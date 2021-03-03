using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDemo
{
    public class RealImage : IImage
    {
        private string fileName { get; set; }

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            loadFromDisk(fileName);
        }

        private void loadFromDisk(string fileName)
        {
            Console.WriteLine("Loading: " + fileName);
        }
        public void Display()
        {
            Console.WriteLine("Displaying: " + fileName);
        }
    }
}
