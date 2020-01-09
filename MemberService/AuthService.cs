using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MemberService
{
    public class AuthService : IAuthService
    {
        private readonly IMemberContext context;

        public AuthService(IMemberContext context)
        {
            this.context = context;
        }

        public bool Create(Member member)
        {
            this.context.Members.Add(member);
            (this.context as DbContext).SaveChanges();
            return true;
        }

        public bool Exist(Member member)
        {
            return this.context.Members
                .Where(model => model.Account == model.Account && model.Password == member.Password)
                .Any();
        }

    }
}
