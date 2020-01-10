using System;
using MemberService;
using Repository.Core;
using Repository.Core.Adapter;
using EntityMember = RSTRepsitory.Models.Member;
using ServiceMember = MemberService.Member;

namespace RSTAdapter
{
    public class MemberAdapter : IDataAdapter<ServiceMember, BaseModel<int>, int>
    {
        public BaseModel<int> ToEntity(ServiceMember model)
        {
            EntityMember member = new EntityMember
            {
                Id = model.Id,
                Account = model.Account,
                Password = model.Password,
                CreateTime = model.CreateTime,
                Delete = model.Delete,
                UpdateTime = model.UpdateTime
            };

            return member;
        }

        public ServiceMember ToService(BaseModel<int> model)
        {
            ServiceMember member = new ServiceMember
            {
                Id = (model as EntityMember).Id,
                Account = (model as EntityMember).Account,
                Password = (model as EntityMember).Password,
                CreateTime = (model as EntityMember).CreateTime,
                Delete = (model as EntityMember).Delete,
                UpdateTime = (model as EntityMember).UpdateTime
            };

            return member;
        }
    }
}
