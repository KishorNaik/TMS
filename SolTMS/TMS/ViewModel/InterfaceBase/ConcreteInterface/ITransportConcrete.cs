using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEntity;
using TMS.ViewModel.InterfaceBase.ConcreteInterface.Common;

namespace TMS.ViewModel.InterfaceBase.ConcreteInterface
{
    interface ITransportConcrete : IProcess,ICancel
    {
        Task<List<ITransport>> GetTransportDataAsync();
    }
}
