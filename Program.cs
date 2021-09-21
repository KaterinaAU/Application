using System;
using System.Collections.Generic;

namespace Ride share
{
    class Program
    {
        static void Main(string[] args)
        {
            
           var car1 = new Car();
            car1.DistanceawayInKm = 4;
           
            var car2 = new Car();
            car2.DistanceawayInKm = 1;
        
            var luxuryCar1 = new LuxuryCar();
            luxuryCar1.DistanceawayInKm = 5;
        

            var extraLargeCar = new ExtraLargeCar();
            extraLargeCar.DistanceawayInKm = 3;

            var cars = new List<Vehicle> {car1, car2, luxuryCar1, extraLargeCar};
            foreach (var car in cars)
            {
               car.ReportDistance();
           }

            while(cars.Count > 0)
            {
            Console.WriteLine("Press any key to choose the vehicle:");
            Console.ReadKey();
            var randomIndexGenerator = new System.Random();
            var indexfarRandomVehicle = randomIndexGenerator.Next(cars.Count);
            var selectedVehicles = cars[indexfarRandomVehicle];
            cars.RemoveAt(indexfarRandomVehicle);

            selectedVehicles.ReportDistance();

            }
            
            Console.WriteLine("We are out of vehicle in your local vicinity");
         } 

        public  class Vehicle
        {
            public int DistanceawayInKm {get; set;}
       
            public virtual void ReportDistance()
            {
                Console.WriteLine($"There is a vehicle {DistanceawayInKm} km away.");
            }
            
        }
        
        public class Car : Vehicle { }
        public class ExtraLargeCar : Vehicle 
        {
            
           public override void ReportDistance()
           {
               Console.WriteLine($"There is a vehicle {DistanceawayInKm} km away.");
           }  
        }   
       
        public class LuxuryCar : Vehicle
        {
            
            public override void ReportDistance()
            {
              Console.WriteLine($"You're in for a smooth ride! There is a luxury vehicle {DistanceawayInKm}km away.");
            }
        }
    }
}
