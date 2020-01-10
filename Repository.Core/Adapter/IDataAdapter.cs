using System;
namespace Repository.Core.Adapter
{
    public interface IDataAdapter<ServiceModel, EntityModel, Index> where EntityModel : BaseModel<Index>
    {

        public ServiceModel ToService(EntityModel model);
        public EntityModel ToEntity(ServiceModel model);

    }
}
