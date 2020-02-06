using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    abstract class Component
    {
        public string Item_name { get; set; }
        public int price { get; set; }
        virtual public void AddChild(Component component) {
        }
        virtual public void RemoveChild(Component component)
        {

        }
        abstract public int Caclulate();
    }
}
