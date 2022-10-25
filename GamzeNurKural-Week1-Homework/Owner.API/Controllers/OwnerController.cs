using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Owner.API.Data;
using System.Collections.Generic;
using System.Linq;

namespace Owner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOwners()
        {
            var ownerDatas = new OwnerData().GetAllOwners();
            return Ok(ownerDatas);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetOwner(int id)
        {
            var ownerData = new OwnerData().GetAllOwners().Where(x => x.Id == id).FirstOrDefault();
            if (ownerData == null)
            {
                return NotFound("User not found.");
            }
            else
            {
                return Ok(ownerData);
            }
        }

        [HttpPost]
        [Consumes("application/json")]
        public IActionResult CreateOwner(Model.Owner owner)
        {
            if (owner == null)
            {
                return BadRequest();
            }
            else
            {
                var ownerData = new OwnerData().GetAllOwners();
                if (owner.Description.ToLower().Contains("hack"))
                {
                    return BadRequest("You cannot write 'hack' words in the description.");
                }
                else
                {
                    ownerData.Add(owner);
                    return Ok(owner);
                }
            }

        }

        [HttpPut("{id:int}")]
        [Consumes("application/json")]
        public IActionResult UpdateOwner(int id, Model.Owner owner)
        {
            if (id != owner.Id)
            {
                return BadRequest("Id's did not match.");
            }
            else if (owner.Description.ToLower().Contains("hack"))
            {
                return BadRequest("You cannot write 'hack' words in the description.");
            }
            else
            {
                var ownerData = new OwnerData().GetAllOwners().Where(x => x.Id == id).FirstOrDefault();

                ownerData.FirstName = owner.FirstName;
                ownerData.Surname = owner.Surname;
                ownerData.Date = owner.Date;
                ownerData.Description = owner.Description;
                ownerData.Type = owner.Type;
                return Ok(owner);
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteOwner(int id)
        {
            var ownerList = new OwnerData().GetAllOwners();
            var ownerData = new OwnerData().GetAllOwners().Where(x => x.Id == id).FirstOrDefault();
            if (ownerData == null)
            {
                return NotFound($"Owner with id {id} not found.");
            }
            else
            {
                ownerList.Remove(ownerData);
                return Ok("Record successfully deleted.");
            }
        }
    }
}
