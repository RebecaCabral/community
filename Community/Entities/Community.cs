using System;

namespace Community.Entities

{
    //Represntação de uma comunidade.
    public class Community
    {
        public string Name { get; set; }
        public string Description { get; set; }  
        public DateTime CreateDate { get; set; }
    }
}
