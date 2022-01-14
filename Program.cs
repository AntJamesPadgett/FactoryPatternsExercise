using System;

namespace FactoryPatternsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWheels;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the amount of tires for the vehicle we wan to create:");

                

                 input = int.TryParse(Console.ReadLine(), out numOfWheels );

            } while (!input);

            var vehicle = VehicleFactory.GetVehicle(numOfWheels);
            vehicle.Drive();
        }
    }
}
