using Microsoft.EntityFrameworkCore;

namespace vega2.Models
{
   public class VehicleMakesDbContext:DbContext
   {
       public VehicleMakesDbContext(DbContextOptions<VehicleMakesDbContext> options)
       :base(options){
           Database.EnsureCreated();
       }

       public DbSet <VehicleMakes> Vehicles { get; set; }
   } 
}