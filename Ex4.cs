using System;

namespace Excercises
{
    class BmwCar: IVehicle
    {
        public void Drive(){
            Console.WriteLine("Driving into the bus stop");
        }
        public void Park(){
            Console.WriteLine("Parking on as many parking spots as possible at the same time");
        }
    }
    class AnyOtherCar: IVehicle
    {
        public void Drive(){
            Console.WriteLine("Driving to the destination");
        }
        public void Park(){
            Console.WriteLine("Parking on a single parking spot");
        }
    }
    class Program
    {
       static void Main(string[] args)
        {   
         var bmwCar = new BmwCar();
         bmwCar.Drive();
         bmwCar.Park();
         var otherCar = new AnyOtherCar();
         otherCar.Drive();
         otherCar.Park();
        }
    }
    interface IVehicle
    {
         void Drive();
         void Park();
    }
}
