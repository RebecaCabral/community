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
            community.CreateDate = DateTime.UtcNow;

            var repository = new CommunityRepository();

            repository.Add(community);

            return Created("", community);
        }
        
        [HttpGet]
        public ActionResult GetCommunities()
        {
            var repository = new CommunityRepository();
            var communities =  repository.Get();
            return Ok(communities);
        }

    }
}
