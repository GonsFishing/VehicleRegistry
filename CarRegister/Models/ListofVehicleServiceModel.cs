using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRegister.Models
{
	public class ListofVehicleServiceModel
	{
        public int Id { get; set; }
        public DateTime ServiceDate { get; set; }
        public string LicencePlateNumber { get; set; }
        public string Description { get; set; }
    }
}