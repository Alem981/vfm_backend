using System.ComponentModel.DataAnnotations;

namespace VehicleFleetManagement.Models;
public class Brand
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;


    //Relations
    public virtual ICollection<Model> Models { get; set; } = new List<Model>();
}
