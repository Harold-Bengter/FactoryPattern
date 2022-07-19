using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise;

internal class VehicleFactory
{
    public static IVehicle GetVehicle(int tires)
    {
        switch(tires)
        {
            case 2:
                return new Motorcylce();
            case 4:
                return new Car();
            case 0:
                return new Boat();
            default:
                return new Car();
        }
    }
}
