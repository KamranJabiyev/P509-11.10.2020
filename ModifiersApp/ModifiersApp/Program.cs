using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoNS;
using DemoNS.NestedNS;
//using DemoNS.NestedNS;

namespace ModifiersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Access modifiers

            #region Public - class, all class members - field,method,property

            //Car car = new Car("BMW", "X5");
            //car.Brand = "Mercedes";
            //Console.WriteLine(car.Model);
            //Console.WriteLine(car.Info());

            #endregion

            #region Private - all class members

            //Car car = new Car();
            ////car.SetSpeed(300);
            ////Console.WriteLine(car.GetSpeed());
            //car.Speed = 300;
            //Console.WriteLine(car.Speed);
            #endregion

            #region Protected - all class members
            //Car car = new Car();
            //car.horsePower
            #endregion

            #region Private readonly - field

            #endregion

            #region Public readonly - field
            //Car car = new Car();
            //Console.WriteLine(car.Color);
            #endregion

            #endregion

            #region NameSpace
            //Car car = new Car();
            //DemoNS.Car car1 = new DemoNS.Car();
            DemoNS.Human human = new DemoNS.Human();
            Animal animal = new Animal();
            Plant plant = new Plant();
            Console.WriteLine();
            #endregion
        }
    }

    class Human { }
}
