using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRegister.Models
{
	public class GetVehicleByRegistrationNumber
	{
		[Required]
		[Display(Name = "Registrationnumber:")]
		public string RegistrationNumber { get; set; }
	}
}