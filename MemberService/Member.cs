﻿using System;
using Repository.Core;

namespace MemberService
{
    public class Member : BaseModel<int>
    {
        public string Account { get; set; }
        public string Password { get; set; }
    }
}
