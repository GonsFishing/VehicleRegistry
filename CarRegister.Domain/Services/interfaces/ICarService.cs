using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegister.Domain.Interfaces
{
    public interface ICarService
    {
        DateTime FirstDateInTraffic(ICar car);
        bool IscarTrafficReady(ICar car);
        bool ServiceBooked(ICar car);
        float YearlyFee(int weight); 
        float YearlyFee(ICar weight); 

    }
}
