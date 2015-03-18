using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEntity;
using TMS.PropertyChanged;
using TMS.ViewModel.InterfaceBase.ViewModelInterface;

namespace TMS.Model
{
    public class TransportModel:PropertyChangedBase,ITransportEntity
    {

        #region Constructor

        public TransportModel()
        {
        }

        public TransportModel(ITransportViewModel ITransportViewModelObj)
        {
            this.ITransportViewModelObj = ITransportViewModelObj;
            
        }

        #endregion

        private int? _TransportId;
        public int? TransportId
        {
            get { return _TransportId; }
            set
            {
                _TransportId = value;
                OnPropertyChanged("TransportId");
            }
        }

        private String _TransportName;
        public string TransportName
        {
            get { return _TransportName; }
            set
            {
                _TransportName = value;
                OnPropertyChanged("TransportName");
            }
        }

        private String _DriverName;
        public string DriverName
        {
            get { return _DriverName; }
            set
            { _DriverName = value;
                OnPropertyChanged("DriverName");
            }
        }

        private long _MobileNo;
        public long MobileNo
        {
            get { return _MobileNo; }
            set
            {
                _MobileNo = value;
                OnPropertyChanged("MobileNo");
            }
        }

        private String _VehicalNo;
        public string VehicalNo
        {
            get { return _VehicalNo; }
            set
            {
                _VehicalNo = value;
                OnPropertyChanged("VehicalNo");
            }
        }

        private bool _IsDelete;
        public bool IsDelete
        {
            get { return _IsDelete; }
            set
            {
                _IsDelete = value;
                OnPropertyChanged("IsDelete");
            }
        }

        private ITransportViewModel _ITransportViewModelObj;

        private ITransportViewModel ITransportViewModelObj
        {
            get;
            set;
        }
    }
}
