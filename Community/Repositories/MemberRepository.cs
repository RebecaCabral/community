using Community.Controllers;
using System.Collections.Generic;

namespace Community.Repositories
{
    using Community.Entities;
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
}
