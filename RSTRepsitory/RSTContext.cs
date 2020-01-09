using System;
using MemberService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace RSTRepsitory
{
    public class RSTContext : DbContext, IMemberContext
    {
        public RSTContext(DbContextOptions<RSTContext> options) : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
    }
}
