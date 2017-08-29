using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using vega2.Models;
namespace vega2.Controllers{
    public class ApiController:Controller
    {
        private readonly models _models;
        public ApiController(models model){
            this._models=model;
        }

        [HttpGet("api/makes")]
        public IEnumerable<Models> GetMakes{

        }
    }
}