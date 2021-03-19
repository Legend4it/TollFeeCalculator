using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator
{
    public class Motorbike : Vehicle
    {
        public string GetVehicleType()
        {
            return "Motorbike";
        }

        public bool IsTollFreeVehicle()
        {
            return Enum.TryParse<TollEnum.TollFreeVehicles>(GetVehicleType(), out _);
        }
    }
}
