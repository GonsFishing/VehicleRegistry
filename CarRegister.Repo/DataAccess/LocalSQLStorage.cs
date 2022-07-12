using CarRegister.Domain.Car;
using CarRegister.Domain.Interfaces;
using CarRegister.Repo.interfaces;
using CarRegister.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_DTO;
using VehicleRegister.Domain.Service;
using VehicleRegister.Domain.Service.interfaces;

namespace CarRegister.Repo.DataAccess
{
	public class LocalSQLStorage : IRepository, IVehicleServiceRepository
	{

		private readonly SQLDataAccessDataContext sqlContext;

		public LocalSQLStorage()
		{
			sqlContext = new SQLDataAccessDataContext();
		}

		//Create
		public void RegisterVehicle(IVehicle vehicle)
		{
			var newVehicle = new Vehicle()
			{
				Model = vehicle.Model,
				Brand = vehicle.Brand,
				Weight = vehicle.Weight,
				VehicleType = vehicle.Type,
				ModelYear = vehicle.ModelYear,
				RegistrationNumber = vehicle.RegistrationNumber
			};
			sqlContext.Vehicles.InsertOnSubmit(newVehicle);
			sqlContext.SubmitChanges();
		}

		public void BookService(BookingServiceDTO service)
		{
			var vehicleService = new VehicleService
			{
				VehicleRegistrationNumber = service.LicencePlateNumber,
				Time = service.ServiceDate,
				Description = "Default Service"
			};

			sqlContext.VehicleServices.InsertOnSubmit(vehicleService);
			sqlContext.SubmitChanges();
		}

		//Read
		public IVehicle GetVehicleById(int vehicleId)
		{
			var getVehicle = sqlContext.Vehicles.Where(x => x.ID == vehicleId).FirstOrDefault();
			var vehicleFactory = new VehicleFactory();

			if (getVehicle != null)
			{
				IVehicle vehicle = vehicleFactory.CreateCar(getVehicle.ID, getVehicle.Model, getVehicle.Brand, getVehicle.VehicleType, getVehicle.Weight, getVehicle.ModelYear, getVehicle.RegistrationNumber);
				return vehicle;
			}
			else
			{
				return null;
			}
		}

		public IVehicle GetVehicleByRegistrationNumber(string registration)
		{
			var getVehicle = sqlContext.Vehicles.Where(x => x.RegistrationNumber == registration).FirstOrDefault();
			var vehicleFactory = new VehicleFactory();

			if (getVehicle != null)
			{
				IVehicle vehicle = vehicleFactory.CreateCar(getVehicle.ID, getVehicle.Model, getVehicle.Brand, getVehicle.VehicleType, getVehicle.Weight, getVehicle.ModelYear, getVehicle.RegistrationNumber);
				return vehicle;
			}
			else
			{
				return null;
			}
		}

		public IEnumerable<IVehicle> GetVehicles()
		{
			var vehicles = new List<IVehicle>();

			var vehicleFactory = new VehicleFactory();
			foreach (var vehicle in sqlContext.Vehicles)
			{
				IVehicle newVehicle = vehicleFactory.CreateCar(vehicle.ID, vehicle.Model, vehicle.Brand, vehicle.VehicleType, vehicle.Weight, vehicle.ModelYear, vehicle.RegistrationNumber);
				vehicles.Add(newVehicle);
			}
			return vehicles;
		}

		public IEnumerable<IVehicleService> GetServices()
		{
			var services = new List<IVehicleService>();
			foreach (var service in sqlContext.VehicleServices)
			{
				IVehicleService addService = new VehicleServiceModel(service.ID, service.VehicleRegistrationNumber, service.Description, service.Time);
				services.Add(addService);
			}
			return services;
		}

		public IEnumerable<IVehicleService> GetServiceHistory(string registrationNumber)
		{
			throw new NotImplementedException();
		}

		//Update
		public void UpdateVehicle(IVehicle vehicle)
		{
			var vehicleUpdate = sqlContext.Vehicles.Where(x => x.ID == vehicle.ID).Single();

			vehicleUpdate.RegistrationNumber = vehicle.RegistrationNumber;
			vehicleUpdate.Model = vehicle.Model;
			vehicleUpdate.Brand = vehicle.Brand;
			vehicleUpdate.Weight = vehicle.Weight;
			vehicleUpdate.VehicleType = vehicle.Type;

			sqlContext.SubmitChanges();
		}

		public void Update(IVehicleService service)
		{
			var servicetoUpdate = sqlContext.VehicleServices.Where(x => x.ID == service.Serviceid).Single();

			servicetoUpdate.VehicleRegistrationNumber = service.LicencePlateNumber;
			servicetoUpdate.Description = service.Description;
			servicetoUpdate.Time = service.Time;

			sqlContext.SubmitChanges();
		}

		//Delete
		public void DeleteVehicle(int id)
		{
			var deleteVehicle = sqlContext.Vehicles.Where(x => x.ID == id).FirstOrDefault();

			sqlContext.Vehicles.DeleteOnSubmit(deleteVehicle);
			sqlContext.SubmitChanges();
		}

		public void DeleteService(int id)
		{
			var deleteService = sqlContext.VehicleServices.Where(x => x.ID == id).FirstOrDefault();

			sqlContext.VehicleServices.DeleteOnSubmit(deleteService);
			sqlContext.SubmitChanges();
		}

		public bool Create(IVehicleService service, int vehicleId)
		{
			throw new NotImplementedException();
		}

		public IVehicleService GetById(int serviceId)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<IVehicleService> GetVehiclesServiceHistory(int vehicleID)
		{
			throw new NotImplementedException();
		}

		public IVehicleService GetVehicleServiceByVehicleId(int vehicleId)
		{
			throw new NotImplementedException();
		}
	}
}
