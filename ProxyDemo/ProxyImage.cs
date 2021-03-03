using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDemo
{
    public class ProxyImage : IImage
    {
        private string fileName { get; set; }
        private RealImage realImage { get; set; }

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            if(realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.Display();
        }
    }
}
