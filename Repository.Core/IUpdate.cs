using System;
using System.Collections.Generic;

namespace Repository.Core
{
    public interface IUpdate<Model, Index> where Model : BaseModel<Index>
    {
        public Model Update(Model model);
        public IEnumerable<Model> Update(IEnumerable<Model> models);
    }
}
