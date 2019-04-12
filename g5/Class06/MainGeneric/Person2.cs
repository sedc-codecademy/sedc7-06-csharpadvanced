using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainGeneric
{
    public class Person2
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public bool HasAge { get; set; }
        //public int Age { get; set; }

        //public NullableInteger Age { get; set; }
        public NullableValue<int> Age { get; set; }

        //public bool HasBankBalance { get; set; }
        //public decimal BankBalance { get; set; }
        public NullableValue<decimal> BankBalance { get; set; }

        public NullableValue<double> Height { get; set; }

        public NullableValue<bool> IsMarried { get; set; }

        public Person2(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = new NullableValue<int>(false, 0);
            BankBalance = new NullableValue<decimal>(false, 0m);
            Height = new NullableValue<double>(false, 0);
            IsMarried = new NullableValue<bool>(false, false);
        }

        //        public override string ToString()
        //        {
        //            // this is ugly code
        //            StringBuilder sb = new StringBuilder($@"FirstName: {FirstName},
        //LastName: {LastName}");

        //            if (HasAge)
        //            {
        //                sb.Append($",\nAge: {Age}");
        //            }

        //            if (HasBankBalance)
        //            {
        //                sb.Append($",\nBankBalance: {BankBalance}");
        //            }

        //            return sb.ToString();

        //            // return $"{FirstName} {LastName} ({Age}) - {BankBalance}$";
        //        }

        public override string ToString()
        {
            // this is ugly code
            StringBuilder sb = new StringBuilder($@"FirstName: {FirstName},
LastName: {LastName}");

            if (Age.HasValue)
            {
                sb.Append($",\nAge: {Age}");
            }

            if (BankBalance.HasValue)
            {
                sb.Append($",\nBankBalance: {BankBalance}");
            }

            if (Height.HasValue)
            {
                sb.Append($",\nHeight: {Height}");
            }

            if (IsMarried.HasValue)
            {
                sb.Append($",\nIsMarried: {IsMarried}");
            }

            return sb.ToString();

            // return $"{FirstName} {LastName} ({Age}) - {BankBalance}$";
        }
    }
}
