using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator
{
    public interface IVehicle
    {

        String GetRegNr();
        String GetVehicleType();
        bool IsTollFreeVehicle();
    }
}