using System;
using System.Collections.Generic;
using System.Linq;
using Repository.Core;
using RSTRepsitory.Models;

namespace RSTRepsitory
{
    public class MemberRepository :
        ICreate<Member, int>,
        IRead<Member, int>,
        IUpdate<Member, int>,
        IDelete<Member, int>
    {
        private readonly RSTContext db;

        public MemberRepository(RSTContext db)
        {
            this.db = db;
        }

        public Member Create(Member model)
        {
            this.db.Members.Add(model);
            this.db.SaveChanges();

            return model;
        }

        public Member Create(IEnumerable<Member> models)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id, bool soft = true)
        {
            throw new NotImplementedException();
        }

        public bool Delete(IEnumerable<int> indices, bool soft = true)
        {
            throw new NotImplementedException();
        }

        public Member Read(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> Read(Func<Member, bool> predicate)
        {
            return this.db.Members.Where(predicate);
        }

        public Member Update(Member model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> Update(IEnumerable<Member> models)
        {
            throw new NotImplementedException();
        }
    }
}
