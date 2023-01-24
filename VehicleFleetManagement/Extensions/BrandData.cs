﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleFleetManagement.Models;

namespace VehicleFleetManagement.Extensions
{
    public static class BrandData
    {
        public static void GenerateData(this EntityTypeBuilder<Brand> entity)
        {
            entity.HasData(
                new Brand { Id = 1, Name = "Acura" },
                new Brand { Id = 2, Name = "Alfa Romeo" },
                new Brand { Id = 3, Name = "Aston Martin" },
                new Brand { Id = 4, Name = "Audi" },
                new Brand { Id = 5, Name = "Bentley" },
                new Brand { Id = 6, Name = "BMW" },
                new Brand { Id = 7, Name = "Bugatti" },
                new Brand { Id = 8, Name = "Buick" },
                new Brand { Id = 9, Name = "Cadillac" },
                new Brand { Id = 10, Name = "Chevrolet" },
                new Brand { Id = 11, Name = "Chrysler" },
                new Brand { Id = 12, Name = "Citroen" },
                new Brand { Id = 13, Name = "Cupra" },
                new Brand { Id = 14, Name = "Dacia" },
                new Brand { Id = 15, Name = "Daewoo" },
                new Brand { Id = 16, Name = "Dodge" },
                new Brand { Id = 17, Name = "DS Automobiles" },
                new Brand { Id = 18, Name = "Ferrari" },
                new Brand { Id = 19, Name = "Fiat" },
                new Brand { Id = 20, Name = "Ford" },
                new Brand { Id = 21, Name = "GMC" },
                new Brand { Id = 22, Name = "Holden" },
                new Brand { Id = 23, Name = "Honda" },
                new Brand { Id = 24, Name = "Hummer" },
                new Brand { Id = 25, Name = "Hyundai" },
                new Brand { Id = 26, Name = "Infiniti" },
                new Brand { Id = 27, Name = "Isuzu" },
                new Brand { Id = 28, Name = "Jaguar" },
                new Brand { Id = 29, Name = "Jeep" },
                new Brand { Id = 30, Name = "Kia" },
                new Brand { Id = 31, Name = "Koenigsegg" },
                new Brand { Id = 32, Name = "Lada" },
                new Brand { Id = 33, Name = "Lamborghini" },
                new Brand { Id = 34, Name = "Lancia" },
                new Brand { Id = 35, Name = "Land Rover" },
                new Brand { Id = 36, Name = "Lexus" },
                new Brand { Id = 37, Name = "Lincoln" },
                new Brand { Id = 38, Name = "Lotus" },
                new Brand { Id = 39, Name = "Maserati" },
                new Brand { Id = 40, Name = "Maybach" },
                new Brand { Id = 41, Name = "Mazda" },
                new Brand { Id = 42, Name = "McLaren" },
                new Brand { Id = 43, Name = "Mercedes-Benz" },
                new Brand { Id = 44, Name = "Mini" },
                new Brand { Id = 45, Name = "Mitsubishi" },
                new Brand { Id = 46, Name = "Nissan" },
                new Brand { Id = 47, Name = "Opel" },
                new Brand { Id = 48, Name = "Pagani" },
                new Brand { Id = 49, Name = "Peugeot" },
                new Brand { Id = 50, Name = "Pontiac" },
                new Brand { Id = 51, Name = "Porsche" },
                new Brand { Id = 52, Name = "Ram" },
                new Brand { Id = 53, Name = "Renault" },
                new Brand { Id = 54, Name = "Rimac" },
                new Brand { Id = 55, Name = "Rolls-Royce" },
                new Brand { Id = 56, Name = "Saab" },
                new Brand { Id = 57, Name = "Saleen" },
                new Brand { Id = 58, Name = "Scion" },
                new Brand { Id = 59, Name = "Seat" },
                new Brand { Id = 60, Name = "Škoda" },
                new Brand { Id = 61, Name = "Smart" },
                new Brand { Id = 62, Name = "Subaru" },
                new Brand { Id = 63, Name = "Suzuki" },
                new Brand { Id = 64, Name = "Tesla" },
                new Brand { Id = 65, Name = "Toyota" },
                new Brand { Id = 66, Name = "Vauxhall" },
                new Brand { Id = 67, Name = "Volkswagen" },
                new Brand { Id = 68, Name = "Volvo" }
               
            );
        }
    }
}
