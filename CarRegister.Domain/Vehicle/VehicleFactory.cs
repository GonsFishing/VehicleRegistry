using Vehicle_DTO;
using CarRegister.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegister.Domain.Car
{
    public class VehicleFactory : IVehicleFactory
    {
		public IVehicle CreateCar(int id, string model, string brand, string type, int weight, int year, string licencePlateNumber)
		{
            if (weight < 1000)
                return new LightWeightVehicle(id, model, brand, type, weight, year, licencePlateNumber);
            if (weight < 2500)
                return new Vehicle(id, model, brand, type, weight, year, licencePlateNumber);
            else
                return new HeavyWeightVehicle(id, model, brand, type, weight, year, licencePlateNumber);
		}
	}
}
