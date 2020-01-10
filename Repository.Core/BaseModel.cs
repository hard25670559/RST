using System;
namespace Repository.Core
{
    public class BaseModel<Index>
    {

        public Index Id { get; set; }
        public bool Delete { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }

    }
}
