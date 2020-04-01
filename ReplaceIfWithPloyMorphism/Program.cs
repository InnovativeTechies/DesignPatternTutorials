using System;
using System.Collections.Generic;

namespace ReplaceIfWithPloyMorphism
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new TwoWheeler());
            vehicles.Add(new FourWheeler());

            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(vehicles[i].GetType().Name);
        }
    }

    public class Vehicle
    {

    }

    public class TwoWheeler:Vehicle
    {

    }
    public class FourWheeler : Vehicle
    {

    }
}
