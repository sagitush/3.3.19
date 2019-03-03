using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._19
{
    class Mobile:IComparable<Mobile>
    {
        public int Year { get; set; }
        public int Model { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }

        public Mobile(int year, int model, int weight, int price)
        {
            Year = year;
            Model = model;
            Weight = weight;
            Price = price;
        }

        public override string ToString()
        {
            return $"mobile {Year},{Model},{Weight},{Price}";
        }

        public int CompareTo(Mobile other)
        {
            return this.Price - other.Price;
        }
    }
}
