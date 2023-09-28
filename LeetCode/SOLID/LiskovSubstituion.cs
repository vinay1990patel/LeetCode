using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SOLID
{
    internal class LiskovSubstituion
    {
        /* the object of a derived class should be able to replace an object of the base class without bringing any errors in the system or modifying the behavior of the base class. 
         * That means child class objects should be able to replace parent class objects without compromising application integrity. */

        static void Main(string[] args)
        {
            Apple apple = new Orange();    // orange class object(child) is not replaced with apple class(base) object which is breaking lsp
            Console.WriteLine(apple.GetColor());  // instead of orrange color we are getting apple color


            // LSP

            IFruit fruit = new Orange1();
            Console.WriteLine( $"Color of orrange : {fruit.GetColor}");

            fruit = new Apple1();

            Console.WriteLine($"Color of orrange : {fruit.GetColor}");

        }

    }

    
}
public class Apple
{
    public virtual string GetColor()
    {
        return "Red";
    }
}
public class Orange : Apple
{
    public override string GetColor()
    {
        return "Orange";
    }

}

// With LSP
interface IFruit
{
    public string GetColor();
}

public class Apple1 : IFruit
{
    public string GetColor()
    {
        return "Red";
    }
}

public class Orange1 :IFruit
{
    public string GetColor()
    {
        return "Orrange";

    }
}



