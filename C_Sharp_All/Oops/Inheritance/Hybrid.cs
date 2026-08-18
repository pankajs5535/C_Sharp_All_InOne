using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_All.Oops.Inheritance
{
    public class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle is starting.");
        }
    }

    public class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }

    public class ElectricCar : Car
    {
        public void ChargeBattery()
        {
            Console.WriteLine("Charging battery.");
        }
    }

    public class Truck : Vehicle
    {
        public void LoadCargo()
        {
            Console.WriteLine("Truck is loading cargo.");
        }
    }

    class Hybrid
    {
        static void Main1(string[] args)
        {
            ElectricCar tesla = new ElectricCar();
            tesla.Start();
            tesla.Drive();
            tesla.ChargeBattery();

            Truck fordTruck = new Truck();
            fordTruck.Start();
            fordTruck.LoadCargo();
        }
    }

}
