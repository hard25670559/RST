using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Repository.Core;
using Repository.Core.Adapter;

namespace MemberService
{
    public class AuthService : IAuthService
    {
        //private readonly IBaseRepository<BaseModel<int>, int> repository;
        private readonly ICreate<BaseModel<int>, int> create;
        private readonly IRead<BaseModel<int>, int> read;
        private readonly IDataAdapter<Member, BaseModel<int>, int> adapter;

        public AuthService(
            //IBaseRepository<BaseModel<int>, int> repository,
            ICreate<BaseModel<int>, int> create,
            IRead<BaseModel<int>, int> read,
            IDataAdapter<Member, BaseModel<int>, int> adapter)
        {
            //this.repository = repository;
            this.create = create;
            this.read = read;
            this.adapter = adapter;
        }

        public Member Create(Member member)
        {
            return this.adapter.ToService(this.create.Create(member as BaseModel<int>));
        }

        public bool Exist(Member member)
        {
            return this.read
                .Read(model =>
                    this.adapter.ToService(model).Account == member.Account &&
                    this.adapter.ToService(model).Password == member.Password)
                .Any();
        }

    }
}
