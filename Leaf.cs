using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class Leaf:Component
    {
        public Leaf(string name,int price)
        {
            this.Item_name = name;
            this.price = price;
        }
        public override int Caclulate()
        {
            Console.WriteLine($"{this.Item_name} product with price:{this.price}");

            return this.price;
        }
    }
}
