using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // root composite
            var box = new Composite("Box", 0);


            // pen and pencil in composite pencil_case
            var pen = new Leaf("pen", 5);
            var pencil = new Leaf("pencil", 3);
            var Pencil_case = new Composite("Pencil case", 0);
            var Ball = new Leaf("Ball", 200);
            Pencil_case.AddChild(pen);
            Pencil_case.AddChild(pencil);


            // add pencil composite as child to the root composite
            box.AddChild(Pencil_case);



            // add leaf component as child to the root composite
            box.AddChild(Ball);

            Console.WriteLine($"Total price of this box  is: {box.Caclulate()}");
        }
    }
}
