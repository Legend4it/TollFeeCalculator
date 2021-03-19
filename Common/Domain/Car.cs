using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator
{
    public class Car : Vehicle
    {
        private readonly string _regnr;
        public Car(string regnr)
        {
            _regnr = regnr;
        }
        public string GetRegNr()
        {
            return _regnr;
        }

        public String GetVehicleType()
        {
            return "Car";
        }

        public bool IsTollFreeVehicle()
        {
            return Enum.TryParse<TollEnum.TollFreeVehicles>(GetVehicleType(), out _);
        }
    }
}