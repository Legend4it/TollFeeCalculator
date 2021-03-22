using System;
using System.Collections.Generic;
using System.Text;
using TollFeeCalculator;

namespace Common
{
    public static class TollEnum
    {
        public static bool IsInTollFreeVehicle(IVehicle vehicle)
        {
            return Enum.TryParse<TollEnum.TollFreeVehicles>(vehicle.GetVehicleType(), out _);
        }
        public static bool IsInTollFreeVehicle(string type)
        {
            return Enum.TryParse<TollEnum.TollFreeVehicles>(type, out _);
        }
        public enum TollFreeVehicles
        {
            Motorbike = 0,
            Tractor = 1,
            Emergency = 2,
            Diplomat = 3,
            Foreign = 4,
            Military = 5
        }

    }
}
