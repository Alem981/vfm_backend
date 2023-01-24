using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleFleetManagement.Models;

namespace VehicleFleetManagement.Extensions;
public static class VehicleData
{
    public static void GenerateData(this EntityTypeBuilder<Vehicle> entity)
    {
        entity.HasData(
            new Vehicle
            {
                Id = 1,
                Registration = "A08-I-415",
                Seats = 7,
                VehicleWeight = 1600,
                ExpRegDate = new DateTime(2023, 08, 11),
                EnginPower = 265,
                ModelId = 3
            },
        new Vehicle
        {
            Id = 2,
            Registration = "A68-E-425",
            Seats = 5,
            VehicleWeight = 1450,
            ExpRegDate = new DateTime(2023, 08, 11),
            EnginPower = 375,
            ModelId = 25
        },
        new Vehicle
        {
            Id = 3,
            Registration = "M55-A-405",
            Seats = 5,
            VehicleWeight = 1575,
            ExpRegDate = new DateTime(2023, 08, 11),
            EnginPower = 309,
            ModelId = 83,
        },
          new Vehicle
          {
              Id = 5,
              Registration = "M21-E-452",
              Seats = 5,
              VehicleWeight = 1575,
              ExpRegDate = new DateTime(2023, 08, 11),
              EnginPower = 309,
              ModelId = 3,
          },
            new Vehicle
            {
                Id = 6,
                Registration = "M33-K-217",
                Seats = 5,
                VehicleWeight = 1475,
                ExpRegDate = new DateTime(2023, 05, 09),
                EnginPower = 125,
                ModelId = 3,
            },
            new Vehicle
            {
                Id = 7,
                Registration = "S323-K-217",
                Seats = 5,
                VehicleWeight = 1275,
                ExpRegDate = new DateTime(2023, 05, 09),
                EnginPower = 103,
                ModelId = 1,
            }
        );
    }
}