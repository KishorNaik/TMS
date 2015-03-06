using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public abstract class AbstractProcess
    {
        #region Abstract Methods

        protected abstract Task<String> InsertAsync<TEntity>(TEntity TEntityObj);

        protected abstract Task<String> UpdateAsync<TEntity>(TEntity TEntityObj);

        protected abstract Task<String> DeleteAsync(int ? Id);

        #endregion
    }
}
