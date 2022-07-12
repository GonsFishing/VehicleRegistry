using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRegister.Models
{
	public class UpdateServiceModel
	{
		public int Id { get; set; }
		public DateTime ServiceDate { get; set; }
		public string LicencePlateNumber { get; set; }
		public string Description { get; set; }
	}
}