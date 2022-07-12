using VehicleRegister.Domain.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegister.Domain.Service
{
    public class VehicleServiceModel : IVehicleService
    {
		public int Serviceid { get; set; }
		public string LicencePlateNumber { get; set; }
		public string Description { get; set; }
		public DateTime Time { get; set; }

		public VehicleServiceModel(int id, string licensePlateNumber, string description, DateTime time)
        {
            Serviceid = id;
            LicencePlateNumber = licensePlateNumber;
            Description = description;
            Time = time;
        }
    }
}
