using Vehicle_DTO;
using CarRegister.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CarRegister.Controllers
{
	public class HomeController : Controller
	{
		//Create
		private readonly string registerVehicle = "https://localhost:44381/api/RegisterVehicle";
		private readonly string registerService = "https://localhost:44381/api/Bookservice";
		//Read
		private readonly string getVehicle = "https://localhost:44381/api/Vehicle";
		private readonly string getAllVehicles = "https://localhost:44381/api/Vehicles";
		private readonly string getAllServices = "https://localhost:44381/api/Services";
		//private readonly string getVehicleServices = "https://localhost:44381/api/Vehicles";
		//private readonly string gettoken = "https://localhost:44381/token";
		//Update
		private readonly string updateVehicle = "https://localhost:44381/api/update/{id}";
		private readonly string updateService = "https://localhost:44381/api/updateService/{id}";
		//Delete
		private readonly string removeVehicle = "https://localhost:44381/api/delete";
		private readonly string removeService = "https://localhost:44381/api/deleteService";

		public ActionResult Index()
		{
			return View();
		}

		//CREATE
		public ActionResult RegisterVehicle()
		{
			return View();
		}

		[HttpPost]
		public ActionResult RegisterVehicle(VehicleModel vehicle)
		{
			using (HttpClient client = new HttpClient())
			{
				var requestVehicle = new VehicleDTO()
				{
					LicencePlateNumber = vehicle.LicencePlateNumber,
					Model = vehicle.Model,
					Brand = vehicle.Brand,
					Weight = vehicle.Weight,
					Type = vehicle.Type,
					Year = vehicle.Year,
				};

				string jsonregistercar = JsonConvert.SerializeObject(requestVehicle);
				var httpcontent = new StringContent(jsonregistercar, Encoding.UTF8, "application/json");
				var result = client.PostAsync(new Uri(registerVehicle), httpcontent).Result;
			}
			return View("Index");
		}

		public ActionResult RegisterService()
		{
			ViewBag.Message = "register your service here.";
			return View();
		}

		[HttpPost]
		public ActionResult RegisterService(BookingServiceModel BookingServiceModel)
		{
			using (HttpClient client = new HttpClient())
			{
				var service = new BookingServiceDTO()
				{
					LicencePlateNumber = BookingServiceModel.LicencePlateNumber,
					ServiceDate = BookingServiceModel.ServiceDate,
				};

				string jsonService = JsonConvert.SerializeObject(service);
				var httpcontent = new StringContent(jsonService, Encoding.UTF8, "application/json");
				var response = client.PostAsync(new Uri(registerService), httpcontent).Result;
			}
			return View("Index");
		}

		// READ
		public ActionResult DetailVehicle(GetVehicleById vehiclebyid)
		{
			var vehicle = GetVehicleUsingId(vehiclebyid);
			return View("vehicle", vehicle);
		}

		public VehicleModel GetVehicleUsingId(GetVehicleById vehiclebyid)
		{
			var request = new VehicleDTO { Id = vehiclebyid.VehicleId };

			string jsonrequest = JsonConvert.SerializeObject(request);
			var httpcontent = new StringContent(jsonrequest, Encoding.UTF8, "application/json");

			using (HttpClient client = new HttpClient())
			{
				var response = client.PostAsync(new Uri(getVehicle), httpcontent).Result;

				if (response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					var jsonGetVehicle = response.Content.ReadAsStringAsync().Result;
					var responseDTO = JsonConvert.DeserializeObject<VehicleDTO>(jsonGetVehicle);

					var result = new VehicleModel
					{
						LicencePlateNumber = responseDTO.LicencePlateNumber,
						Model = responseDTO.Model,
						Brand = responseDTO.Brand,
						Weight = responseDTO.Weight,
						Type = responseDTO.Type,
						Year = responseDTO.Year,
					};
					return result;

				}
				else { return null; }
			}
		}

		[HttpGet]
		public ActionResult Vehicles()
		{
			var Vehiclelist = new List<ListofVehicleModel>();
			using (HttpClient client = new HttpClient())
			{
				//client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Session["tokenkey"].ToString());
				var response = client.GetAsync(new Uri(getAllVehicles)).Result;
				if (response != null)
				{
					var jsonstring = response.Content.ReadAsStringAsync().Result;
					var repo = JsonConvert.DeserializeObject<GetAllVehicles>(jsonstring);

					foreach (var vehicle in repo.Vehicles)
					{
						var result = new ListofVehicleModel
						{
							Id = vehicle.Id,
							Model = vehicle.Model,
							Year = vehicle.Year,
							Brand = vehicle.Brand,
							Type = vehicle.Type,
							LicencePlateNumber = vehicle.LicencePlateNumber,
							Weight = vehicle.Weight,
						};
						Vehiclelist.Add(result);
					}
					ViewBag.Message = Vehiclelist;
				}
			}
			return View(Vehiclelist);
		}

		[HttpGet]
		public ActionResult Services()
		{
			var serviceList = new List<ListofVehicleServiceModel>();
			using (HttpClient client = new HttpClient())
			{
				var response = client.GetAsync(new Uri(getAllServices)).Result;
				if (response != null)
				{
					var jsonstring = response.Content.ReadAsStringAsync().Result;
					var repo = JsonConvert.DeserializeObject<GetAllVehicleServices>(jsonstring);

					foreach (var service in repo.Services)
					{
						var result = new ListofVehicleServiceModel
						{
							Id = service.Id,
							LicencePlateNumber = service.LicencePlateNumber,
							Description = service.Description,
							ServiceDate = service.ServiceDate
						};
						serviceList.Add(result);
					}
					ViewBag.Message = serviceList;
				}
			}
			return View(serviceList);
		}

		public ActionResult VehicleServices()
		{
			var Vehiclelist = new List<ListofVehicleModel>();
			using (HttpClient client = new HttpClient())
			{
				var response = client.GetAsync(new Uri(getAllServices)).Result;
				if (response != null)
				{
					var jsonstring = response.Content.ReadAsStringAsync().Result;
					var repo = JsonConvert.DeserializeObject<GetAllVehicles>(jsonstring);

					foreach (var vehicle in repo.Vehicles)
					{
						var result = new ListofVehicleModel
						{
							Id = vehicle.Id,
							Model = vehicle.Model,
							Year = vehicle.Year,
							Brand = vehicle.Brand,
							Type = vehicle.Type,
							LicencePlateNumber = vehicle.LicencePlateNumber,
							Weight = vehicle.Weight,
						};
						Vehiclelist.Add(result);
					}
					ViewBag.Message = Vehiclelist;
				}
			}
			return View(Vehiclelist);
		}
		//UPDATE
		public ActionResult UpdateVehicle(UpdateVehicleModel vehicle)
		{
			return View("UpdateVehicle", vehicle);
		}

		[HttpPost]
		public ActionResult UpdateVehicle(VehicleModel vehicle)
		{
			var vehicleUpdateRequest = new VehicleDTO
			{
				Id = vehicle.Id,
				LicencePlateNumber = vehicle.LicencePlateNumber,
				Brand = vehicle.Brand,
				Model = vehicle.Model,
				Type = vehicle.Type,
				Year = vehicle.Year,
				Weight = vehicle.Weight,
			};
			string jsonUpdatedVehicle = JsonConvert.SerializeObject(vehicleUpdateRequest);
			var httpContent = new StringContent(jsonUpdatedVehicle, Encoding.UTF8, "application/json");

			using (HttpClient client = new HttpClient())
			{
				var response = client.PostAsync(new Uri(updateVehicle), httpContent).Result;

				if (response.StatusCode != System.Net.HttpStatusCode.OK)
					return View("Error");
			}
			ViewBag.Message = "Vehicle has been updated";
			return View("Success");
		}

		public ActionResult UpdateService(UpdateServiceModel service)
		{
			return View(service);
		}

		[HttpPost]
		public ActionResult UpdateService(ServiceModel service)
		{
			var serviceUpdateRequest = new BookingServiceDTO
			{
				Id = service.Id,
				LicencePlateNumber = service.LicencePlateNumber,
				ServiceDate = service.ServiceDate,
				Description = service.Description
			};

			string jsonUpdatedService = JsonConvert.SerializeObject(serviceUpdateRequest);
			var httpContent = new StringContent(jsonUpdatedService, Encoding.UTF8, "application/json");

			using (HttpClient client = new HttpClient())
			{
				var response = client.PostAsync(new Uri(updateService), httpContent).Result;

				if (response.StatusCode != System.Net.HttpStatusCode.OK)
					return View("Error");
			}
			ViewBag.Message = "Service has been updated";
			return View("Success");
		}
		//Delete
		[HttpGet]
		public ActionResult DeleteVehicle(DeleteVehicleModel vehicle)
		{
			return View(vehicle);
		}

		[HttpPost]
		public ActionResult DeleteVehicle(int id)
		{
			var httpcontent = new StringContent("");
			using (HttpClient client = new HttpClient())
			{
				var response = client.PostAsync(new Uri($"{removeVehicle}?id={id}"), httpcontent).Result;
				if (response.StatusCode != System.Net.HttpStatusCode.OK)
				return View("Error");
			}
			ViewBag.Message = "Vehicle has been deleted";
			return View("Success");
		}

		[HttpGet]
		public ActionResult DeleteService(DeleteServiceModel vehicle)
		{
			return View(vehicle);
		}

		[HttpPost]
		public ActionResult DeleteService(int id)
		{
			var httpcontent = new StringContent("");
			using (HttpClient client = new HttpClient())
			{
				var response = client.PostAsync(new Uri($"{removeService}?id={id}"), httpcontent).Result;
				if (response.StatusCode != System.Net.HttpStatusCode.OK)
					return View("Error");
			}
			ViewBag.Message = "Vehicle has been deleted";
			return View("Success");
		}
	}
}