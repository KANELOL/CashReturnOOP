using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CashReturnCalculation
{
    class CashValueList
    {
        List<CashValue> Liste { get; }
        public CashValueList()
        {
            Liste = new List<CashValue>();
        }
    
        public void Add(CashValue cv)
        {
            Liste.Add(cv);
        }
        public int Length()
        {
            return Liste.Count;
        }
        public CashValue FirstOrDefault(int cashItem)
        {
                return Liste.FirstOrDefault(c => c.GetValue() == cashItem);
        }
        public void Sort(int amount)
        {
            Liste.Reverse();
            var remaining = amount;
            int count = 0;
            foreach(var x in Liste)
            {
                count = remaining / x.GetValue();
                if(count > 0) {
                    remaining -= count * x.GetValue();
                    Console.WriteLine($"- {count}x{x.GetValue()}kr");
                }
            }
        }
        public CashValueList GetSetCashValueList()
        {
            CashValueList cashItemValues = new CashValueList();
             cashItemValues.Add(new CashValue(1, true));
            cashItemValues.Add(new CashValue(5, true));
            cashItemValues.Add(new CashValue(10, true));
            cashItemValues.Add(new CashValue(20, true));
            cashItemValues.Add(new CashValue(50, false));
            cashItemValues.Add(new CashValue(100, false));
            cashItemValues.Add(new CashValue(200, false));
            cashItemValues.Add(new CashValue(500, false));
            cashItemValues.Add(new CashValue(1000, false));
            return cashItemValues;
        }
    }
}
