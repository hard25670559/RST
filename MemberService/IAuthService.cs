using System;
namespace MemberService
{
    public interface IAuthService
    {

        public bool Exist(Member member);
        public bool Create(Member member);

    }
}
