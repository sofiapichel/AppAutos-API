using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.Repositories.Generic
{
    public interface IGenericRepository<T>
    {
        Task<T> Delete(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Insert(T model);
        Task<T> Update(T model);
    }
}
