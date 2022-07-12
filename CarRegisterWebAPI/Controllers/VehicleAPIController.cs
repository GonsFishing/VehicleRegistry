using CarRegister.Repo.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vehicle_DTO;
using CarRegister.Domain.Interfaces;
using CarRegister.Domain.Car;
using CarRegister.Repo.DataAccess;
using VehicleRegister.Domain.Service.interfaces;
using CarRegister.Repo.Interfaces;
using CarRegister.Models;
using VehicleRegister.Domain.Service;

namespace CarRegisterWebAPI.Controllers
{

	public class VehicleAPIController : ApiController
	{
		private readonly IRepository repository;
		private readonly IVehicleServiceRepository services;

		public VehicleAPIController(IRepository repo,
								IVehicleServiceRepository serv)
		{
			this.repository = repo;
			this.services = serv;
		}

		//Create
		[HttpPost]
		[Route("api/RegisterVehicle")]
		public IHttpActionResult RegisterVehicle(VehicleDTO Vehicle)
		{
			IVehicleFactory factory = new VehicleFactory();
			var vehicle = factory.CreateCar(
				Vehicle.Id,
				Vehicle.Model,
				Vehicle.Brand, 
				Vehicle.Type, 
				Vehicle.Weight, 
				Vehicle.Year, 
				Vehicle.LicencePlateNumber);

			repository.RegisterVehicle(vehicle);
			return Ok();
		}

		[HttpPost]
		[Route("api/Bookservice")]
		public IHttpActionResult Bookservice(BookingServiceDTO service)
		{
			//var vehicle = repository.GetVehicleByRegistrationNumber(service.LicencePlateNumber);
			//service.Id = vehicle.ID;

			repository.BookService(service);
			return Ok();
		}

		[HttpPost]
		[Route("api/GetVehicleId")]
		public IVehicle GetVehicleId(BookingServiceDTO service)
		{
			var vehicle = repository.GetVehicleByRegistrationNumber(service.LicencePlateNumber);
			return vehicle;
		}

		//Read
		[HttpGet]
		[Route("api/Vehicles")]
		public IHttpActionResult GetListOfAllCars()
		{
			var response = new GetAllVehicles();
			foreach (var vehicle in repository.GetVehicles())
			{
				response.Vehicles.Add(new VehicleDTO()
				{
					Brand = vehicle.Brand,
					Year = vehicle.ModelYear,
					Model = vehicle.Model,
					Type = vehicle.Type,
					Weight = vehicle.Weight,
					LicencePlateNumber = vehicle.RegistrationNumber,
					Id = vehicle.ID,
				});
			}
			return Ok(response);
		}

		[HttpGet]
		[Route("api/Services")]
		public IHttpActionResult GetListOfAllServices()
		{

			var response = new GetAllVehicleServices();
			foreach (var service in services.GetServices())
			{
				response.Services.Add(new BookingServiceDTO()
				{
					Id = service.Serviceid,
					LicencePlateNumber = service.LicencePlateNumber,
					Description = service.Description,
					ServiceDate = service.Time
				});
			}
			return Ok(response);
		}

		[HttpPost]
		[Route("api/vehicle")]
		public IHttpActionResult GetVehicleById(VehicleDTO vehicle)
		{
			var getvehicle = repository.GetVehicleById(vehicle.Id);

			if (getvehicle != null)
			{
				var response = new VehicleDTO()
				{
					Id = getvehicle.ID,
					LicencePlateNumber = getvehicle.RegistrationNumber,
					Model = getvehicle.Model,
					Brand = getvehicle.Brand,
					Type = getvehicle.Type,
					Weight = getvehicle.Weight,
				};
				return Ok(response);
			}
			else
				return NotFound();
		}

		//Update
		[HttpPost]
		[Route("api/update/{id}")]
		public IHttpActionResult UppdateVehicle(VehicleDTO updatedVehicle)
		{
			IVehicleFactory factory = new VehicleFactory();
			var uppdatecar = factory.CreateCar(
				updatedVehicle.Id,
				updatedVehicle.Model,
				updatedVehicle.Brand, 
				updatedVehicle.Type,
				updatedVehicle.Weight,
				updatedVehicle.Year, 
				updatedVehicle.LicencePlateNumber);
			repository.UpdateVehicle(uppdatecar);

			return Ok();
		}

		//Update
		[HttpPost]
		[Route("api/updateService/{id}")]
		public IHttpActionResult UppdateService(BookingServiceDTO updatedService)
		{
			var newService = new VehicleServiceModel(
				updatedService.Id,
				updatedService.LicencePlateNumber,
				updatedService.Description,
				updatedService.ServiceDate
				);

			services.Update(newService);
			return Ok();
		}

		//Delete
		[HttpPost]
		[Route("api/delete")]
		public IHttpActionResult DeleteVehicle(int id)
		{
			repository.DeleteVehicle(id);
			return Ok();
		}

		[HttpPost]
		[Route("api/deleteservice")]
		public IHttpActionResult DeleteService(int id)
		{
			services.DeleteService(id);
			return Ok();
		}

		//not implomented
		[HttpGet]
		[Route("api/servicehistory")]
		public IHttpActionResult GetCarServiceHistory(string regNR)
		{
			throw new NotImplementedException();
			//var servicehistory = repository.GetServiceHistory(id);
			//return Ok();
		}
	}
}
