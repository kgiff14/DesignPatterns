using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDemo.CommandInterface
{
    public class BuyStock : IOrder
    {
        private Stock stock { get; set; }

        public BuyStock(Stock stock)
        {
            this.stock = stock;
        }

        public void Execute()
        {
            stock.Buy();
        }
    }
}
