using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using vega2.Models;
namespace vega2.Controllers{
    [Route("api/[Controller]")]
    public class ApiController:Controller
    {
        private readonly VehicleMakesDbContext _models;
        public ApiController(VehicleMakesDbContext model){
            this._models=model;
            /* new VehicleMakes[]
                {
                    new VehicleMakes{
                        Make="BMW",
                        VModels=new model[]{new model{name="x215"}}
                    },
                    new VehicleMakes
                    {
                        Make="AUD",
                        VModels=new model[]{new model{name="x75"}}
                    }
                }*/
            this._models.Vehicles.Add(
                new VehicleMakes
                    {
                        Make="AUD",
                        models=new model[]{new model{name="x75"}}
                    }
            );
            _models.SaveChanges();
        }

        [HttpGet("makes")]
        public IEnumerable<VehicleMakes> GetMakes(){
            return _models.Vehicles.ToList();
        }
    }
}