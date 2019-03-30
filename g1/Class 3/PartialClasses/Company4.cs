using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClasses
{
    partial class Company
    {
        //some methods here
        private double _netIncomeCoefficient = 0.1;
        private double _totalAssetsCoefficient = 2.5;

        public double GetNetIncome()
        {
            return _netIncomeCoefficient * Revenue;
        }
        public double GetTotalAssets()
        {
            return _totalAssetsCoefficient * Revenue;
        }
        public string ProductList(List<string> products)
        {
            StringBuilder listProducts = new StringBuilder();
            foreach (var p in products)
                listProducts.Append(p+"; ");
            return listProducts.ToString();
        }
        partial void PrintInfo()
        {
            Console.WriteLine(
                $"Name:\t\t\t {Name}\n"+
                $"Industry:\t\t {Industry}\n"+
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
