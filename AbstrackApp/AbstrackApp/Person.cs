using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrackApp
{
    sealed class Person:Human
    {
        public Person(int id,string name,string surname):base(id,name,surname)
        {
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
