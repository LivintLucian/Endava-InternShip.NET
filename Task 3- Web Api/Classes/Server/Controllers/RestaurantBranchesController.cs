using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Server.Data;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantBranchesController : ControllerBase
    {
        [HttpGet]

        public ActionResult<List<RestaurantBranch>> Get()
        {
            var requirementsBranches = from r in RestaurantContext.RestaurantBranches
                orderby r.Id
                select r;
            return requirementsBranches.ToList();
        }
    }
}
