using System;
using System.Collections;
using System.Collections.Generic;

namespace Repository.Core
{
    public interface IRead<Model, Index> where Model : BaseModel<Index>
    {

        public Model Read(Index id);
        public IEnumerable<Model> Read(Func<Model, bool> predicate);

    }
}
