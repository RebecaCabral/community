using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Community.Repositories
{
    using Community.Entities;

    public class CommunityRepository
    {
        static List<Community> communities = new List<Community>();

        public void Add(Community community) 
        {
            communities.Add(community);
        }
        public List<Community> Get()
        {
            return communities;
        }

    }
}
