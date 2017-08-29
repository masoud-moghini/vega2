using Microsoft.EntityFrameworkCore;

namespace vega2.Models
{
   public class VehicleMakesDbContext:DbContext
   {
       public models(DbContextOptions<models> options)
       :base(options){

       }

       public DbSet <models> VehicleModels { get; set; }
   } 
}