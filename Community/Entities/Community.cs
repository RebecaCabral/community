using System;

namespace Community.Entities
{
    public class Community
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }  
        public DateTime CreateDate { get; set; }
    }
}
