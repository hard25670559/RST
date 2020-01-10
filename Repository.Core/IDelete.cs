using System;
using System.Collections.Generic;

namespace Repository.Core
{
    public interface IDelete<Model, Index> where Model : BaseModel<Index>
    {

        public bool Delete(Index id, bool soft = true);
        public bool Delete(IEnumerable<Index> indices, bool soft = true);

    }
}
