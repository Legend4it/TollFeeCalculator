using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator
{
    public class Car : Vehicle
    {
        public Car(string regnr)
        {
            _type = this.GetType().Name;
            _regnr = regnr;
        }

        public override String GetVehicleType()
        {
            return base.GetVehicleType();
        }

        public override bool IsTollFreeVehicle()
        {
            return base.IsTollFreeVehicle();
        }
    }
}