using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRegister.Models
{
	public class UpdateVehicleModel
	{
        [Display(Name = "Vehicle Id:")]
        public int VehicleId { get; set; }

        [Required]
        [Display(Name = "Model year")]
        public int Year { get; set; }

        [Required]
        [Display(Name = "Vehicle model")]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Vehicle brand")]
        public string Brand { get; set; }

        [Required]
        [Display(Name = "Licenseplate number")]
        [StringLength(6, ErrorMessage = "A licensenumber should consist of 6 characters.")]
        public string LicencePlateNumber { get; set; }

        [Required]
        [Display(Name = "Enter Vehicle Weight")]
        [Range(0, 650000, ErrorMessage = "That amount is not legal on the road, make sure your numbers are correct")]
        public int Weight { get; set; }

        [Required]
        [Display(Name = "What Kind of Vehicle do you have?")]
        public string Type { get; set; }
    }
}