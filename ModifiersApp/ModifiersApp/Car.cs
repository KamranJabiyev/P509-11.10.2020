using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiersApp
{
    class Car
    {
        //property
        public string Brand { get; set; }
        public string Model { get; set; }
        //field
        private int _speed;

        protected int horsePower;

        private readonly int _price=300;

        public readonly string Color="Red";

        public Car()
        {
            Console.WriteLine("Bir mashin yaradildi");
        }

        public Car(string brand,string model,int price)
        {
            Brand = brand;
            Model = model;
            _price = price;
            Color = "Blue";
        }

        //encapsulation
        public int Speed {
            get
            {
                return _speed;
            }
            set
            {
                if(value>0 && value <= 300)
                {
                    _speed = value;
                    return;
                }
                Console.WriteLine("Duzgun suret daxil edin");
            }
        }

        //public void SetSpeed(int s)
        //{
        //    if(s>0 && s <= 300)
        //    {
        //        _speed = s;
        //        return;
        //    }
        //    Console.WriteLine("Duzgun suret daxil edin");
        //}

        //public int GetSpeed()
        //{
        //    return _speed;
        //}

        public virtual string Info()
        {
            _speed = 240;
            horsePower = 1;
            return $"{Brand} {Model} {_speed} {PriMethod()} {horsePower} {_price} {Color}";
        }

        private string PriMethod()
        {
            return "I am private";
        }
    }
}
