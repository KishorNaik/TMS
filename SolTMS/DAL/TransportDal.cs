using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using IEntity;

namespace DAL
{
    public class TransportDal : AbstractProcess,IDisposable
    {
        protected override Task<string> InsertAsync<TEntity>(TEntity TEntityObj)
        {
            try
            {
                ITransport ITransport = TEntityObj as ITransport;
                throw new NotImplementedException();

            }
            catch (Exception)
            {
                throw;
            }
        }

        protected override Task<string> UpdateAsync<TEntity>(TEntity TEntityObj)
        {
            throw new NotImplementedException();
        }

        protected override Task<string> DeleteAsync(int?  Id)
        {
            throw new NotImplementedException();
        }

        protected virtual Task<IEnumerable<ITransport>> GetTransportDataAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
