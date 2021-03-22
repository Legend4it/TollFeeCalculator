using System;
using System.Collections.Generic;
using System.Text;
using TollFeeCalculator;

namespace Common.Domain
{
    public abstract class Vehicle : IVehicle
    {
        protected string _regnr;
        protected string _type;

        public string GetRegNr()
        {
            return _regnr;
        }

        public virtual string GetVehicleType()
        {
            return _type;
        }

        public virtual bool IsTollFreeVehicle()
        {
            return TollEnum.IsInTollFreeVehicle(_type);
        }

    }
}
