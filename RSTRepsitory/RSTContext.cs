using System;
using Microsoft.EntityFrameworkCore;
using RSTRepsitory.Models;

namespace RSTRepsitory
{
    public class RSTContext : DbContext
    {
        public RSTContext(DbContextOptions<RSTContext> options) : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
    }
}
