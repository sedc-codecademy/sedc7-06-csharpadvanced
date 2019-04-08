using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class Item
    {
        public int Id { get; set; }
        public double Price { get; set; }
        private double _Discount;
        public double Discount
        {
            get
            {
                return _Discount;
            }
            set
            {
                _Discount = value;
            }
        }
        public Item()
        {

        }
        public Item(int id, double price, double discount)
        {
            Id = id;
            Price = price;
            Discount = discount;
        }
    }
}
