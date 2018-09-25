using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace CarInventory.Repositories
{
    public interface IRepository<TModel> where TModel : class
    {
        void Add(TModel model);
        TModel Edit(TModel model);
        void Remove(TModel model);
        
        TModel Get(int id);
        IEnumerable<TModel> GetAll();
        
    }
}