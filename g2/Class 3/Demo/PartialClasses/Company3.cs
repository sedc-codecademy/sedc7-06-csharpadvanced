using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class Company
    {
        public string ProductList(List<string> products)
        {
            StringBuilder listProducts = new StringBuilder();
            foreach (var p in products)
            {
                listProducts.Append(p + "; ");
            }
            return listProducts.ToString();
        }
        partial void PrintInfo()
        {
            Console.WriteLine(
                $"Name:\t\t\t {Name}\n" +
                $"Industry:\t\t {Industry}\n" +
                $"Founded:\t\t {Founded}\n" +
                $"Headquarters:\t\t {Headquarters}\n" +
                $"Products:\t\t {ProductList(Products)}\n" +
                $"Revenue:\t\t {Revenue:C}\n" +
                $"Employees:\t\t {NumberOfEmploees:F3}\n" +
                $"Area served:\t\t {AreaServed}\n" +
                $"Website:\t\t {Website}\n"
                );
        }
    }
}
