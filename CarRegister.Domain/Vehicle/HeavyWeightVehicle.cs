using CarRegister.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegister.Domain.Car
{
    public class HeavyWeightVehicle : IVehicle
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Weight { get; set; }
		public int ModelYear { get; set; }
        public string RegistrationNumber { get; set; }

        public bool IsTaxPayed { get; }

        public bool IsServiceBooked { get; }

        public DateTime RegistredForTraffic { get; }

		public HeavyWeightVehicle (int id, string model, string carbrand, string cartyp, int carwieght, int year, string licenseplatenumber)
        {
            this.ID = id; 
            this.Model = model;
            this.Brand = carbrand;
            this.Type = cartyp;
            this.Weight = carwieght;
            this.ModelYear = year;
            this.RegistrationNumber = licenseplatenumber; 
        }

        public bool IsVehicleTrafficReady(IVehicle car)
        {
            throw new NotImplementedException();
        }
    }
}
