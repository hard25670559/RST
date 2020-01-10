using System;
using Repository.Core;

namespace RSTRepsitory.Models
{
    public class Member : BaseModel<int>
    {

        public string Account { get; set; }
        public string Password { get; set; }

    }
}
