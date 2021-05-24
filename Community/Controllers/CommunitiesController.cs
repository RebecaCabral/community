using Microsoft.AspNetCore.Mvc;
using System;

namespace Community.Controllers
{
    using Community.Entities;
    using Community.Inputs;
    using Community.Repositories;

    [Route("api/communities")]
    [ApiController]
    public class CommunitiesController : ControllerBase
    {
        [HttpPost]
        public ActionResult CreateCommunity([FromBody]CreateCommunity createCommunity)
        {
            var community = new Community();
            community.Name = createCommunity.Name;
            community.Description = createCommunity.Description;
            community.Id = Guid.NewGuid();
            community.CreateDate = DateTime.UtcNow;

            var repository = new CommunityRepository();

            repository.Add(community);

            return Created("", community);
        }

        [HttpGet]
        public ActionResult GetCommunities([FromQuery] string name, [FromQuery] string description, [FromQuery]DateTime date)
        {
            var repository = new CommunityRepository();
            var communities = repository.GetNameAndDescription(name, description, date);
            return Ok(communities);
        }

        [HttpGet("{id}")]
        public ActionResult GetCommunities(Guid id)
        {
            var repository = new CommunityRepository();
            var community = repository.GetId(id);

            if (community == null)
                return NotFound();

            return Ok(community);
        }

        // DELETE

        [HttpDelete("{id}")]
        public ActionResult DeleteCommunity(Guid id)
        {
            var repository = new CommunityRepository();
             repository.Remove(id);

            return Ok();
        }
    }
}
