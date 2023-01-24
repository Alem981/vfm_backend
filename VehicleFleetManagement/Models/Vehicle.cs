using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleFleetManagement.Models;
public class Vehicle
{
    [Key]
    public int Id { get; set; }   

    public string Registration { get; set; } = string.Empty;
    public int Seats { get; set; } = 2; 
    public int VehicleWeight/*Kg*/ { get; set; }
    public DateTime ExpRegDate { get; set; } = new DateTime(2023, 08, 11);
    public int EnginPower/*kW*/ {get; set; }

    [ForeignKey("Model")]
    public int ModelId { get; set; }   
    public ICollection<Model> Models { get; set; } = new List<Model>();
       
}