namespace vega2.Models
{
    public class VehicleMakes
    {
        public long id { get; set; }
        public string Make { get; set; }
        public virtual model[] VModels { get; set; }
    }
}