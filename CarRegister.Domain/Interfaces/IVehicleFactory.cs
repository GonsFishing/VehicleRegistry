using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegister.Domain.Interfaces
{
    public interface IVehicleFactory
    {
        IVehicle CreateCar(int id, string model, string brand, string type, int weight, int year, string LicencePlateNumber);
    }
}
