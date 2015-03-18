using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RepositoryInterface;

namespace DAL
{
    public class TransportDal : ITransportDal
    {
      
        public Task<string> InsertAsync<TEntity>(TEntity tEntityObj)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync<TEntity>(TEntity tEntityObj)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<dynamic>> GetDataAsync()
        {
            throw new NotImplementedException();
        }
    }
}
