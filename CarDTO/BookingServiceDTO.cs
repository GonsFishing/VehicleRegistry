using System;
using System.Collections.Generic;

namespace Vehicle_DTO
{
    public class BookingServiceDTO
    {
		public int Id { get; set; }
		public string LicencePlateNumber { get; set; }
        public DateTime ServiceDate { get; set; }
		public string Description { get; set; }
	}

    public class GetAllVehicleServices
    {
        public IList<BookingServiceDTO> Services { get; set; } = new List<BookingServiceDTO>();
    }
}
