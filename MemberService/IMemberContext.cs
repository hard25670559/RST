using System;
using Microsoft.EntityFrameworkCore;

namespace MemberService
{
    public interface IMemberContext
    {
        public DbSet<Member> Members { get; set; }
    }
}
