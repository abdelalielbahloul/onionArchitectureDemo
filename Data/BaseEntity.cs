using System;

namespace Data
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string IPAddress { get; set; }
    }
}
