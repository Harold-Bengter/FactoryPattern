using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class Motorcylce : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Buiding a New Motorcycle!");
        }
    }
}
