using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrackApp
{
    class Human
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Human(int id,string name,string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} {Surname}";
        }

    }
}
