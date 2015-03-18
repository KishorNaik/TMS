using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEntity;
using DAL;
using TMS.ViewModel.InterfaceBase.ConcreteInterface;
using TMS.ViewModel.InterfaceBase.ConcreteInterface.Common;

namespace TMS.ViewModel.Concrete.Module.Transport
{
    public sealed partial class TransportConcrete : ITransportConcrete
    {

        #region Implement ITransportConcrete Interface Implement
        public Task<List<ITransportEntity>> GetTransportDataAsync()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
