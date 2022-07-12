using CarRegister.Domain.Car;
using CarRegister.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegister.Domain.Services
{
    public class CarService : ICarService
    {
        public bool IscarTrafficReady(ICar car)
        {
            return car.IsTaxPayed; 
            

        }

        public bool ServiceBooked(ICar car)
        {
            return car.IsServiceBooked; 
 
        }

        public DateTime FirstDateInTraffic(ICar car)
        {

            return car.CarRegistredForTraffic.Date;
        }

        public float YearlyFee(int weight)
        {
            throw new NotImplementedException();
        }
        public float YearlyFee(ICar car)
        {
            float Lowtax = 1200;
            float mediumtax = 1800;
            float highTax = 4500;
            if (car.CarWeight < 1800)
                return Lowtax;
            else if (car.CarWeight > 1800 && car.CarWeight < 2500)
                return mediumtax;
            else
                return highTax; 
            
        }
    }
}
