using System;
using System.Collections.Generic;

namespace Repository.Core
{
    public interface ICreate<Model, Index> where Model : BaseModel<Index>
    {

        public Model Create(Model model);
        public Model Create(IEnumerable<Model> models);

    }
}
