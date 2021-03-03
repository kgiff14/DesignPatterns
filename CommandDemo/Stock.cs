using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDemo
{
    public class Stock
    {
        private string name = "abc";
        private int quantity = 10;

        public void Buy()
        {
            Console.WriteLine("Stock - Name: " + name + ", Quantity: " + quantity + " bought");
        }
        public void Sell()
        {
            Console.WriteLine("Stock - Name: " + name + ", Quantity: " + quantity + " sold");
        }
    }
}
