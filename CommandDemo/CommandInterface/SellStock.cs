using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDemo.CommandInterface
{
    public class SellStock : IOrder
    {
        private Stock Stock { get; set; }

        public SellStock(Stock stock)
        {
            this.Stock = stock;
        }

        public void Execute()
        {
            Stock.Sell();
        }
    }
}
