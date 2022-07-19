using FactoryPatternExercise;

Console.Write("We would like to build you a vehicle!");
Console.WriteLine();
Console.WriteLine("How many tires does your vehicle have? 0,2 or 4?");
int tires = int.Parse(Console.ReadLine());
IVehicle vehicle = VehicleFactory.GetVehicle(tires);
vehicle.Drive();
