namespace Vehicles
{
    public abstract class Vehicle
    {
        public abstract double CalculateSpeed();
    }
    public class Car : Vehicle
    {
        public double Distance;
        public double Time;

        public Car(double distance, double time)
        {
            Distance = distance;
            Time = time;
        }

        public override double CalculateSpeed()
        {
            return Distance / Time;
        }
    }
    public class Bike : Vehicle
    {
        public double Distance;
        public double Time;

        public Bike(double distance, double time)
        {
            Distance = distance;
            Time = time;
        }

        public override double CalculateSpeed()
        {
            return Distance / Time * 0.8;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles =
            {
                new Car(36, 56),
                new Bike(60, 70),
                new Bike(96, 140),
                new Car(500, 86),
                new Car(45, 23),
                new Bike(190, 180),
                new Car(45, 12)
            };
            foreach (Vehicle vehicle in vehicles) {
                Console.WriteLine($"Speed: {vehicle.CalculateSpeed()} Km/min");
                Console.WriteLine();
            }
        }
    }
}
