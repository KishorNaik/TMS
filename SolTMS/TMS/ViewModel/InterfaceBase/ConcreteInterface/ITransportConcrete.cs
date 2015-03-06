using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.ViewModel.InterfaceBase.ConcreteInterface.Common;

namespace TMS.ViewModel.InterfaceBase.ConcreteInterface
{
    interface ITransportConcrete : IProcess,ICancel
    {
    }
}
