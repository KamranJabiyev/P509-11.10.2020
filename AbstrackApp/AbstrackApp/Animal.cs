using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrackApp
{
    abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal is create");
        }
        public abstract void Eat();

        public void Test()
        {
            Console.WriteLine("in abstrack");
        }
    }

    abstract class Bird:Animal
    {
        public abstract void Fly();
    }

    class Eagle : Bird,IRunable,IVoice
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }

        public void Run()
        {
            Console.WriteLine("Run as Eagle"); ;
        }

        public void Sound()
        {
            throw new NotImplementedException();
        }
    }
}
