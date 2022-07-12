using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRegister.Models
{
	public class GetVehicleById
	{
		[Display(Name = "Vehicle Id:")]
		public int VehicleId { get; set; }
	}
}