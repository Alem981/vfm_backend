using AutoMapper;
using System.Collections;
using System.Collections.Generic;
using VehicleFleetManagement.Data;
using VehicleFleetManagement.Interface;
using VehicleFleetManagement.Models;

namespace VehicleFleetManagement.Services;

public class VehicleService : BaseReadService<vfm.Model.VehicleDto, Vehicle>, IVehicleService
{
    
    public VehicleService (DataContext context, IMapper mapper)
        :base(context, mapper)
    {      
    }
     
}

