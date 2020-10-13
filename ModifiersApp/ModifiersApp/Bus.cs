using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiersApp
{
    class Bus:Car
    {
        public int PassengerCount;
        public Bus(string brand,string model,int price,int pasCount):base(brand,model,price)
        {
            PassengerCount = pasCount;
        }

        public void Test()
        {
            horsePower = 2;
            Console.WriteLine($"{Brand} {Model} {Info()} {horsePower} {Color}");
        }
    }
}
