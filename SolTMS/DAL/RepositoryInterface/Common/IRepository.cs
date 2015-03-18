using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RepositoryInterface.Common
{
    public interface IRepository
    {
        Task<String> InsertAsync<TEntity>(TEntity tEntityObj);
        Task<String> UpdateAsync<TEntity>(TEntity tEntityObj);

        Task<String> DeleteAsync(int id);
    }
}
