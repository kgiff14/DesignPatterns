using CommandDemo.CommandInterface;
using System;

namespace CommandDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();

            BuyStock buyStock = new BuyStock(stock);
            SellStock sellStock = new SellStock(stock);

            Broker broker = new Broker();
            broker.TakeOrder(buyStock);
            broker.TakeOrder(sellStock);

            broker.PlaceOrders();
        }
    }
}
