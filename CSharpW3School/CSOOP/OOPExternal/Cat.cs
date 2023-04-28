using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExternal
{
    // Inheritance from Polimorphism
    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat say: meo meo");
        }
    }
}
