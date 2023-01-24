namespace vfm.Model;
public partial class VehicleDto
{
    public int Id { get; set; }
    public string Registration { get; set; } = string.Empty;
    public int Seats { get; set; } = 2;
    public int VehicleWeight/*Kg*/ { get; set; }
    //public DateTime ExpRegDate { get; set; } = new DateTime(2023, 08, 11);
    public int EnginPower/*kW*/ { get; set; }
    public int ModelId { get; set; }
}
