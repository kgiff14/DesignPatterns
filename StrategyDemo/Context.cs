using StrategyDemo.Strat;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDemo
{
    public class Context
    {
        private IStrategy strategy { get; set; }

        public Context(IStrategy strategy) => this.strategy = strategy;

        public int ExecuteStrategy(int num1, int num2) => strategy.DoOperation(num1, num2);
    }
}
