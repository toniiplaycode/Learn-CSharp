using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExternal
{
    class Pig : Ianimal, Ianimal2
    {
        public void animalAction()
        {
            Console.WriteLine("The pig action: forward, goback");
        }
        public void animalAction2()
        {
            Console.WriteLine("the pig action 2: turn left, turn right ");
        }
    }
}
