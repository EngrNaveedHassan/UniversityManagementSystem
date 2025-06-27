using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    internal interface IService <T>
    {
        Task<bool> Create(T entity);
        Task<List<T>> Read(List<T> entities);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<T?> GetById(string id);
    }
}
