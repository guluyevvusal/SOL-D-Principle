namespace Liskov_Substitution_Principle
{
    public abstract class Vehicle
    {
        public abstract void StartEngine();
    }

    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }
    }

    public class ElectricCar : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Electric car started.");
        }
    }

    public class Driver
    {
        public void Drive(Vehicle vehicle)
        {
            vehicle.StartEngine();
        }
    }
}
