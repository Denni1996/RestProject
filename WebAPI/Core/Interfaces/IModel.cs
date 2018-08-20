using System;
using System.Collections.Generic;

namespace WebAPI.Core.Interfaces
{
    public interface IModel<M> where M : BaseModel
    {
        void Create(M model);
        void Delete(M model);
        void Update(M model);
        M Get(int id);
        List<M> Get();
    }
}
