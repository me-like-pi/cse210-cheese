//using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Sandbox World!");
//     }
// }

namespace count;

class Program
{
    static void Main(string[] args)
    {
       string greeting = "Hello sandbox World!";
       Console.WriteLine($"{greeting}");

       List<RoundShape> mylist = new List<RoundShape>();

       mylist.Add(new Circle(1.0));
       mylist.Add(new Cylinder(1.0,2.0));
       mylist.Add(new Sphere(1.0));

       foreach (RoundShape shape in mylist)
       {
        Console.WriteLine(shape.Area());
       }
    }
}
