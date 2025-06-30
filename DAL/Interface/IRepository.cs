using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRepository <T>
    {
        Task Create (T entity);
        Task<List<T>> Read ();
        void Update (T entity);
        Task Delete (T entity);
        Task<T?> GetById (string id);
    }
}
