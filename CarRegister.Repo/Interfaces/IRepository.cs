using CarRegister.Domain.Interfaces;
using CarRegister.Repo.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_DTO;
using VehicleRegister.Domain.Service.interfaces;

namespace CarRegister.Repo.interfaces
{
   public interface IRepository
    {
        //Create
        void RegisterVehicle(IVehicle vehicle);
        void BookService(BookingServiceDTO service);

        //Read
        IEnumerable<IVehicle> GetVehicles();
        IVehicle GetVehicleById(int id);
        IVehicle GetVehicleByRegistrationNumber(string registration);

        //Update
        void UpdateVehicle(IVehicle vehicle);

		//Delete
		void DeleteVehicle(int id);
    }
}
