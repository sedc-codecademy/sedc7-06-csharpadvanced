using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced_Class4.Interfaces;
using static CSharpAdvanced_Class4.Enums.Enums;

namespace CSharpAdvanced_Class4
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }

    public class Part : Item, IPrice
    {
        public double Price { get; set; }

        public double GetTotalPrice()
        {
            return Price * Quantity;
        }
    }

    public class Module : Item, IPrice, IDiscont
    {
        private List<Part> _parts = new List<Part>();

        public double Price
        {
            get
            {
                // return _parts.Sum(part => part.Price * part.Quantity);

                double price = 0;
                foreach (var part in _parts)
                {
                    price += part.GetTotalPrice();
                }
                return price;
            }
        }
        public double Discount { get; set; }

        public Module() { }
        public Module(string name)
        {
            Name = name;
        }

        public void AddPartToModule(Part part, int quantity = 1)
        {
            part.Quantity = quantity;
            _parts.Add(part);
        }

        public void SetDiscount(double discount)
        {
            // TODO: Implement the SetDiscount() method for the Modules
            /*
             * The percentage is a number in the range [0,100]. 5% == 0.05, 10% == 0.1
             * The method should set the Discount property to values between [0.00, 1.00]
             */
            if (discount < 0)
            {
                throw new ArgumentException("Discount cannot be less than zero", "discount");
            }
            if (discount > 100)
            {
                throw new ArgumentException("Discount cannot be more than one hundred percent", "discount");
            }
            Discount = discount / 100;
        }

        public double GetPriceWithDiscount()
        {
            return Price * (1 - Discount);
        }

        public double GetTotalPrice()
        {
            return GetPriceWithDiscount();
        }
    }

    public class Configuration : Item, IPrice, IDiscont
    {
        public Colors BoxColor { get; set; }
        private List<Part> _parts = new List<Part>();
        private List<Module> _modules = new List<Module>();

        public double Price
        {
            get
            {
                var partsPrice = _parts.Sum(part => part.GetTotalPrice());
                var modulesPrice = _modules.Sum(module => module.GetTotalPrice());
                var price = partsPrice + modulesPrice;
                return price;

                // return _parts.Sum(part => part.GetTotalPrice()) + _modules.Sum(module => module.GetTotalPrice());
            }
        }

        public double Discount { get; private set; }

        public Configuration() { }
        public Configuration(Colors boxColor)
        {
            BoxColor = boxColor;
        }

        public void AddPartToProduct(Part part, int quantity = 1)
        {
            part.Quantity = quantity;
            _parts.Add(part);
        }

        public void AddModuleToProduct(Module module, int quantity = 1)
        {
            module.Quantity = quantity;
            _modules.Add(module);
        }

        public double GetPriceWithDiscount()
        {
            return Price * (1 - Discount);
        }

        public void SetDiscount(double discount)
        {
            if (discount < 0)
            {
                throw new ArgumentException("Discount cannot be less than zero", "discount");
            }
            if (discount > 100)
            {
                throw new ArgumentException("Discount cannot be more than one hundred percent", "discount");
            }
            Discount = discount / 100;
        }

        public double GetTotalPrice()
        {
            return GetPriceWithDiscount();
        }
    }
}
