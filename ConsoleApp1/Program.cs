using System;
using System.Collections.Generic;
using TollFeeCalculator;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var vehicle1 = new Car("ABC123");
            GetFee(vehicle1, GetDatesData());

            var vehicle2 = new Motorbike("ABC123");
            GetFee(vehicle2, GetDatesData());
            Console.ReadKey();

        }
        public static void GetFee(IVehicle vehicle, List<DateTime> dates)
        {
            var tc = new TollCalculator();
            Console.WriteLine($"Total Fee:{tc.GetTollFee(vehicle, dates.ToArray())}, Vehicle Typ:{vehicle.GetVehicleType()}");

        }
        public static List<DateTime> GetDatesData()
        {
            return new List<DateTime>() {
            new DateTime(2021, 03, 18, 06, 20, 00),
            new DateTime(2021, 03, 18, 06, 35, 00),
            new DateTime(2021, 03, 18, 06, 44, 00),
            new DateTime(2021, 03, 18, 06, 45, 00),
            new DateTime(2021, 03, 18, 06, 55, 00),
            new DateTime(2021, 03, 18, 07, 10, 00),
            new DateTime(2021, 03, 18, 07, 55, 00),
            new DateTime(2021, 03, 18, 08, 20, 00),
            new DateTime(2021, 03, 18, 08, 55, 00),
            new DateTime(2021, 03, 18, 14, 50, 00),
            new DateTime(2021, 03, 18, 15, 00, 00),
            new DateTime(2021, 03, 18, 15, 20, 00),
            new DateTime(2021, 03, 18, 16, 55, 00),
            new DateTime(2021, 03, 18, 17, 00, 00),
            new DateTime(2021, 03, 18, 18, 55, 00)
        };
        }

    }
}
