using System;

namespace Community.Entities
{
    public class Member
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
