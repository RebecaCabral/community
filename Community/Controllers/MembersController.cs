using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Community.Controllers
{
    [ApiController]
    [Route("members")]
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

    public class Member
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
    }

    public class MemberRepository
    {
        private static List<Member> members = new List<Member>();

        public void Add(Member member)
        {
            members.Add(member);
        }

        public List<Member> Get()
        {
            return members;
        }
    }

    public class CreateMember
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
