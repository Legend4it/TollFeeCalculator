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
        private readonly string _regnr;

        public Motorbike(string regnr)
        {
            _regnr = regnr;
        }
        public string GetRegNr()
        {
            return _regnr;
        }

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
