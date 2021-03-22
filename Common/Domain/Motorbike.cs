using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator
{
    public class Motorbike : Vehicle
    {
        public Motorbike(string regnr)
        {
            _type = this.GetType().Name;
            _regnr = regnr;
        }

        public override string GetVehicleType()
        {
            return base.GetVehicleType();
        }

        public override bool IsTollFreeVehicle()
        {
            return base.IsTollFreeVehicle();
        }
    }
}
