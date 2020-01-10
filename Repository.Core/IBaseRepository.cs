using System;
namespace Repository.Core
{
    public interface IBaseRepository<Model, Index> :
        ICreate<Model, Index>,
        IRead<Model, Index>,
        IUpdate<Model, Index>,
        IDelete<Model, Index> where Model : BaseModel<Index>
    {
    }
}
