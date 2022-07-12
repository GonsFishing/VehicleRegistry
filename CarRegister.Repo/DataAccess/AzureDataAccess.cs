using CarRegister.Domain.Interfaces;
using CarRegister.Repo.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRegister.Domain.Car;
//using CarRegister.Domain.Service;

//namespace CarRegister.Repo.DataAccess
//{

	//public class AzureDataAccess : IRepository
	//{
	//	private readonly AzureDataBaseAccessDataContext vehicleContext;
	//	public AzureDataAccess()
	//	{
	//		vehicleContext = new AzureDataBaseAccessDataContext();
	//	}


	//	public void RegisterCar(IVehicle car)
	//	{
	//		var new_car = new Car()
	//		{
	//			ID = car.ID,
	//			Model = car.Model,
	//			Year = car.Year,
	//			CarBrand = car.Brand,
	//			CarType = car.Type,
	//			CarWeight = car.Weight,
	//			LicensePlateNumber = car.RegistrationNumber
	//		};
	//		vehicleContext.Cars.InsertOnSubmit(new_car);
	//		vehicleContext.SubmitChanges();
	//	}

	//	public IService BookService(IVehicle car, string serviceinfo)
	//	{
	//		// 1. Hämta bilen (använd ID)
	//		var getcar = vehicleContext.Cars.Where(x => x.ID == car.ID).FirstOrDefault();


	//		// 2. skapa en ny service. (använda ID)
	//		var service = new CarService()
	//		{
	//			ServiceInfo = serviceinfo,
	//			IsServiceCompleted = false,
	//		};


	//		vehicleContext.CarServices.InsertOnSubmit(service);
	//		vehicleContext.SubmitChanges();
	//		// 3. Skapa relationen mellan Bil & Service via ID från bilen och servicerna.
	//		var car_service = new Car_CarService
	//		{
	//			CarServiceID = service.ID,
	//			CarID = getcar.ID
	//		};

	//		vehicleContext.Car_CarServices.InsertOnSubmit(car_service);
	//		vehicleContext.SubmitChanges();

	//		IService domainservice = new Service(serviceinfo, 5000);

	//		return domainservice;
	//	}


	//	public void DeleteCar(string registrationNumber)
	//	{
	//		var requestremovecar = vehicleContext.Cars.Where(x => x.LicensePlateNumber == registrationNumber).SingleOrDefault();
	//		vehicleContext.Cars.DeleteOnSubmit(requestremovecar);
	//		vehicleContext.SubmitChanges();
	//	}

	//	public IVehicle GetCarByRegistrationNumber(string registrationNumber)
	//	{
	//		var car = vehicleContext.Cars.Where(x => x.LicensePlateNumber == registrationNumber).Single();
	//		var carfactory = new CarFactory();
	//		IVehicle requestcar = carfactory.CreateCar(car.ID, car.Model, car.CarBrand, car.CarType, car.CarWeight, car.Year, car.LicensePlateNumber);
	//		return requestcar;
	//	}
	//	public IEnumerable<IVehicle> GetListofAllCars()
	//	{
	//		var cars = new List<IVehicle>();
	//		var carfactory = new CarFactory();
	//		foreach (var car in vehicleContext.Cars)
	//		{
	//			IVehicle cardomain = carfactory.CreateCar(car.ID, car.Model, car.CarBrand, car.CarType, car.CarWeight, car.Year, car.LicensePlateNumber);
	//			cars.Add(cardomain);
	//		}
	//		return cars;
	//	}

	//	public IEnumerable<ICarService> GetServiceHistory(string registrationNumber)
	//	{
	//		var requestservicehistories = vehicleContext.Cars.Where(x => x.LicensePlateNumber == registrationNumber).SelectMany(s => s.Car_CarServices).Select(service => service.CarService).ToList();
	//		return new List<ICarService>();
	//	}


	//	public void UpdateService(ICarService service)
	//	{

	//		throw new NotImplementedException();
	//	}

	//	public void UpdateCar(IVehicle car)
	//	{

	//		var cartouppdate = vehicleContext.Cars.Where(x => x.LicensePlateNumber == car.RegistrationNumber).Single();

	//		cartouppdate.CarBrand = car.Brand;
	//		cartouppdate.Model = car.Model;
	//		cartouppdate.Year = car.Year;
	//		cartouppdate.CarWeight = car.Weight;

	//		vehicleContext.SubmitChanges();
	//	}

//		public void RegisterVehicle(IVehicle vehicle)
//		{
//			throw new NotImplementedException();
//		}

//		public IEnumerable<IVehicle> GetVehicles()
//		{
//			throw new NotImplementedException();
//		}

//		public IVehicle GetVehicleByRegistrationNumber(string registrationNumber)
//		{
//			throw new NotImplementedException();
//		}

//		IEnumerable<IVehicleService> IRepository.GetServiceHistory(string registrationNumber)
//		{
//			throw new NotImplementedException();
//		}

//		public void UpdateVehicle(IVehicle vehicle)
//		{
//			throw new NotImplementedException();
//		}

//		public void UpdateService(IVehicleService service)
//		{
//			throw new NotImplementedException();
//		}

//		public void DeleteVehicle(string registrationNumber)
//		{
//			throw new NotImplementedException();
//		}
//	}
//}
