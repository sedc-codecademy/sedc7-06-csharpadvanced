using System.Collections.Generic;

namespace CustomersSorting
{
    public class CustomerMonthlySpendComparer : IComparer<Customer>  {
        public int Compare(Customer c1, Customer c2)
        {
            if (c1 != null && c2 != null)
                return c1.MonthlySpend - c2.MonthlySpend;

            return 0;
        }

       
    }
}