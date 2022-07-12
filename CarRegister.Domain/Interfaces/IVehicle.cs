using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegister.Domain.Interfaces
{
   public  interface IVehicle
    {
        int ID { get; set;}
        string RegistrationNumber { get; set; }
        string Model { get; set; }
        string Brand { get; set; }
        string Type { get; set; }
        int Weight { get; set; }
        int ModelYear { get; set; }
        bool IsServiceBooked { get; }
        DateTime RegistredForTraffic { get; }
        bool IsVehicleTrafficReady(IVehicle vehicle);
    }
}
