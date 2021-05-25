using Community.Controllers;
using System.Collections.Generic;

namespace Community.Repositories
{
    using Community.Entities;
    using System;

    public class MemberRepository
    {
        private static List<Member> members = new List<Member>();

        public void Add(Member member)
        {
            members.Add(member);
        }

        public List<Member> Get(string name)
        {
            var getName = members.FindAll(x => x.Name == name);
            if (getName.Count == 0)
                return members;
            
            return getName;
        }

        public void Remove(Guid id)
        {
            members.RemoveAll(x => x.Id == id);
        }
    }
}
