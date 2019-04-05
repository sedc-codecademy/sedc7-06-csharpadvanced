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
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }  
    }

    public class Part : Item, IPrice
    { 
        public double GetPrice()
        {
            return Price;
        } 
    }

    public class Module : Item, IPrice, IDiscont
    {
        private List<Part> _parts = new List<Part>(); 

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
        public double GetPrice()
        {
            double price = 0.0;
            foreach (var part in _parts)
            {
                price += (part.Price * part.Quantity);
            }
            return price;
        }
        public void SetDiscount(double discount)
        {
            double _d = 0.0;
            if (discount < 0.0)
                _d = 0;
            else if (discount > 0.0 && discount <= 1.0)
                _d = discount;
            else if (discount > 1.0 && discount <= 100.0)
                _d = discount / 100.0;
            else _d = 1.0;

            #region IF alterantive
            //if (discount < 0)
            //{
            //    _d = 0;
            //}
            //else
            //{
            //    if (discount > 0 && discount <= 1.0)
            //    {
            //        _d = discount;
            //    }
            //    else
            //    {
            //        if(discount > 1.0 && discount <= 100.0)
            //        {
            //            _d = discount / 100.0;
            //        }
            //        else
            //        {
            //            _d = 1.0;
            //        }
            //    }
            //}
            #endregion

            Discount = _d;
        }
        public double GetPriceWithDiscount()
        {
            return GetPrice() * (1 - Discount);
        }
    }

    public class Configuration : Item, IPrice, IDiscont
    {
        public Colors BoxColor { get; set; }
        private List<Part> _parts = new List<Part>();
        private List<Module> _modules = new List<Module>();
        public List<Part> Parts { get; set; }
        public List<Module> Modules { get; set; } 

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
         
        public double GetPrice()
        {
            double price = 0.0;
            foreach (var part in _parts)
            {
                price += (part.Price * part.Quantity);
            }
            foreach (var module in _modules)
            {
                price += (module.GetPrice() * module.Quantity);
            }
            return price;
        }
        public double GetPriceWithDiscount()
        {
            return GetPrice() * (1 - Discount);
        }
        public void SetDiscount(double discount)
        {
            double _d = 0.0;
            if (discount < 0.0)
                _d = 0;
            else if (discount > 0.0 && discount <= 1.0)
                _d = discount;
            else if (discount > 1.0 && discount <= 100.0)
                _d = discount / 100.0;
            else _d = 1.0;

            Discount = _d;
        }

    }

}
