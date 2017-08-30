using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace vega2.Models
{
    public class VehicleMakes
    {
        public long id { get; set; }
        public string Make { get; set; }
        public ICollection<model> models { get; set; }
        public VehicleMakes(){
            models=new Collection<model>();
        }
        
    }
}