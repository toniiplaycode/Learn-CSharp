using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExternal
{
    // Abstract class
    abstract class Fruit
    {
        // abstract method
        public abstract void nameOfFruit();
        // regular method
        public void benefit()
        {
            Console.WriteLine("very good for health");
        }
    }
}
