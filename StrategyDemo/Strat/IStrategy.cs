using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDemo.Strat
{
    public interface IStrategy
    {
        public int DoOperation(int num1, int num2);
    }
}
