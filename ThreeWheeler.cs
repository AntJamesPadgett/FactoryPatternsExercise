using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternsExercise
{
     public class ThreeWheeler : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving up the mountains!!!");
        }
    }
}
