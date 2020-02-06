using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class Composite:Component
    {
        List<Component> Childerns;
        public Composite(string name , int price)
        {
            this.Item_name = name;
            this.price = price;
            Childerns = new List<Component>();
        }
        public override void AddChild(Component component)
        {
            this.Childerns.Add(component);
        }
        public override void RemoveChild(Component component)
        {
            this.Childerns.Remove(component);
        }
        public override int Caclulate()
        {
            int total = 0;
            Console.WriteLine($"{this.Item_name} contains the following products with prices:");
            foreach ( Component s in Childerns)
            {
                total += s.Caclulate();
            }
            return total;
        }
    }
}
