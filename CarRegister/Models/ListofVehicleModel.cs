using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRegister.Models
{
    public class ListofVehicleModel
    {
            public int Id { get; set; }
            public int Year { get; set; }
            public string Model { get; set; }
            public string Brand { get; set; }
            public string LicencePlateNumber { get; set; }
            public int Weight { get; set; }
            public string Type { get; set; }   
    }
}