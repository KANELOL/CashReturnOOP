using System;
using System.Collections.Generic;
using System.Text;

namespace CashReturnCalculation
{
    class CashValueWithCountList
    {
        List<CashValueWithCount> List;
        public CashValueWithCountList()
        {
            List = new List<CashValueWithCount>();
        }
        public void Add(CashValueWithCount CVWC)
        {
            List.Add(CVWC);
        }
        public void Reverse()
        {
            List.Reverse();
        }
        public int GetTotalValue()
        {
            var sum = 0;
            foreach(var x in List)
            {
                sum += x.Sum();
            }
            return sum;
        }
    }
}
