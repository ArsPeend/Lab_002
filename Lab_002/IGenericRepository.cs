using System;
using System.Collections.Generic;

namespace Lab_002 
{
    public interface IGenericRepository<TEntity> where TEntity : class
{
    IEnumerable<TEntity> Get();

}
    }
