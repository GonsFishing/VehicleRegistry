using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRegister.Domain.Service.interfaces;

namespace CarRegister.Repo.Interfaces
{
	public interface IVehicleServiceRepository
	{
        bool Create(IVehicleService service, int vehicleId);
        IVehicleService GetById(int serviceId);
        IEnumerable<IVehicleService> GetServices();
        IEnumerable<IVehicleService> GetVehiclesServiceHistory(int vehicleID);
        IVehicleService GetVehicleServiceByVehicleId(int vehicleId);
        void Update(IVehicleService service);
        void DeleteService(int serviceId);
    }
}
