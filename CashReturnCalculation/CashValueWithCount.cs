namespace CashReturnCalculation
{
    class CashValueWithCount
    {
        CashValue CashValue;
        private int Value;
        private int Count;
        public CashValueWithCount(CashValue cashValue, int count)
        {
            CashValue = cashValue;
            Value = CashValue.GetValue();
            Count = count;
        }
        public int Sum()
        {
            return Value * Count;
        }
    }
}