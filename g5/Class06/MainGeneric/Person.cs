using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainGeneric
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int? Age { get; set; }

        public decimal? BankBalance { get; set; }

        public double? Height { get; set; }

        public bool? IsMarried { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
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
