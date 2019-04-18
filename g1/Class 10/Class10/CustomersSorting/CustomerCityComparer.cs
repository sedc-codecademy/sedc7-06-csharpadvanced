using System;
using System.Collections.Generic;

namespace CustomersSorting
{
    public class CustomerCityComparer : IComparer<Customer> {
        public int Compare(Customer c1, Customer c2)
        {
            if (c1 != null && c2 != null)
                return String.CompareOrdinal(c1.City, c2.City);

            return 0;
        }
    }
}