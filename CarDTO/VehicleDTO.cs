using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_DTO
{
    public class VehicleDTO
    {
        public int Id { get; set; } 
        public int Year { get; set; }
        public int Weight { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string LicencePlateNumber { get; set; }
        public string Type { get; set; }
	}

    public class GetAllVehicles 
    {
        public IList<VehicleDTO>Vehicles { get; set; } = new List<VehicleDTO>();
    }
}
