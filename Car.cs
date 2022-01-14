using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternsExercise
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The car is driving!!!WooHoo!");
        }
    }
}
