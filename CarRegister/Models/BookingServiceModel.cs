using System;
using System.ComponentModel.DataAnnotations;

namespace CarRegister.Models
{
    public class BookingServiceModel
    {
        [Required]
        [Display(Name = "Date for Service")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ServiceDate { get; set; }
        [Required]
        [Display(Name = "Plate number")]
        [StringLength(6)]
        public string LicencePlateNumber { get; set; }

    }
}