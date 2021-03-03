using System;
using System.Collections.Generic;
using System.Text;

namespace StateDemo
{
    public interface IState
    {
        public void DoAction(Context context);
    }
}
