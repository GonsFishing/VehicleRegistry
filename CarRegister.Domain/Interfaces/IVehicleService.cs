using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegister.Domain.Service.interfaces
{
    public interface IVehicleService
    {
        int Serviceid { get; set; }
        string LicencePlateNumber  { get; set; }
        string Description { get; set; }
        DateTime Time { get; set; }
    }
}
