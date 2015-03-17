using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEntity;
using TMS.Model;
using TMS.ViewModel.InterfaceBase.ViewModelInterface.UI;

namespace TMS.ViewModel.InterfaceBase.ViewModelInterface
{
    public interface ITransportViewModel : IEnable,IFocus
    {
        TransportModel SelectTransportModel { get; set; }

        ObservableCollection<TransportModel> TransportData { get; set; }
    }
}
