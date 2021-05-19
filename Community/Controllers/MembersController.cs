using Community.Entities;
using Community.Inputs;
using Community.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Community.Controllers
{
    [ApiController]
    [Route("api/members")]
    public class MembersController : ControllerBase
    {
        [HttpPost]
        public ActionResult CreateMember(CreateMember createMember)
        {
            var member = new Member();
            member.CreateDate = DateTime.UtcNow;
            member.Email = createMember.Email;
            member.Name = createMember.Name;

            var memberRepository = new MemberRepository();

            memberRepository.Add(member);

            return Created("", member);
        }

        [HttpGet]
        public ActionResult GetMembers()
        {
            var memberRepository = new MemberRepository();

            var members = memberRepository.Get();

            return Ok(members);
        }
    }
}
