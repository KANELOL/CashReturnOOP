using System;
using System.Collections.Generic;
using System.Text;

namespace CashReturnCalculation
{
    class CashValue
    {
        private int Value;
        private bool IsCoin;

        public CashValue(int value, bool isCoin)
        {
            Value = value;
            IsCoin = isCoin;
        }
        public int GetValue()
        {
            return Value;
        }
    }
}
