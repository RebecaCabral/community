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

        public Community GetId(Guid Id)
        {
            return communities.Where(x => x.Id == Id).FirstOrDefault();
        }
        
        public IEnumerable<Community> GetNameAndDescription(string name, string description, DateTime data)
        {
            if (name == null && description == null && data == default)
                return communities;

            return communities.Where(x => x.Name == name || x.Description == description || x.CreateDate == data);
        }
        
        public void Remove(Guid Id)
        {
            communities.RemoveAll(x => x.Id == Id);
        }
    }
}
