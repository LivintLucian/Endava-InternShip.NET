using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Server.Data;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<OrderTable> GetById(int id)
        {
            var request = RestaurantContext.ReservationsTables.FirstOrDefault(o => o.Id == id);
            return request == null ? (ActionResult<OrderTable>) NotFound() : Ok(request);
        }

        [HttpPost]

        public ActionResult<OrderTable> Post(OrderTable orderTable)
        {
            RestaurantContext.ReservationsTables.Add(orderTable);

            var a = new HttpClient();
            return CreatedAtAction(nameof(GetById), new { id = orderTable.Id }, orderTable);
        }

        [HttpDelete]

        public ActionResult<OrderTable> Delete(OrderTable orderTable)
        {
            RestaurantContext.ReservationsTables.Remove(orderTable);
            
            return Ok(orderTable);
        }

        [HttpPut]

        public ActionResult<OrderTable> Put(OrderTable orderTable, int id)
        {
            var result = RestaurantContext.ReservationsTables.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                result.FirstName = orderTable.FirstName;
                result.LastName = orderTable.LastName;
                result.DinnerGuests = orderTable.DinnerGuests;
                result.PhoneNumber = orderTable.PhoneNumber;
                result.RestaurantBranchId = orderTable.RestaurantBranchId;
            }
            else
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpPatch]
        public ActionResult<OrderTable> Patch(OrderTable orderTable, int id, string firstName, string lastName)
        {
            var result = RestaurantContext.ReservationsTables.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                result.FirstName = orderTable.FirstName;
                result.LastName = orderTable.LastName;
            }
            else
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
