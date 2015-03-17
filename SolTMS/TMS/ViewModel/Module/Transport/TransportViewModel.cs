using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;
using TMS.PropertyChanged;
using TMS.ViewModel.InterfaceBase.ViewModelInterface;

namespace TMS.ViewModel.Module.Transport
{
    public class TransportViewModel :PropertyChangedBase, ITransportViewModel
    {

        #region Constructor

        public TransportViewModel()
        {
            if(SelectTransportModel==null)
            SelectTransportModel = new TransportModel(this);
        }

        #endregion

        #region Business Properties

        private TransportModel _SelectTransportModel;
        public TransportModel SelectTransportModel
        {
            get { return _SelectTransportModel; }
            set
            {
                _SelectTransportModel = value;
                OnPropertyChanged("SelectTransportModel");
            }
        }

        private ObservableCollection<TransportModel> _TransportData;
        public ObservableCollection<TransportModel> TransportData
        {
            get { return _TransportData; }
            set
            {
                _TransportData = value;
                OnPropertyChanged("TransportData");
            }
        }

        #endregion


        #region UI Properties

        private bool _Enable;
        public bool Enable
        {
            get { return _Enable; }
            set
            {
                _Enable = value;
                OnPropertyChanged("Enable");
            }
        }

        private bool _Focus;
        public bool Focus
        {
            get
            {
                return _Focus;
            }
            set
            {
                _Focus = value;
                OnPropertyChanged("Focus");
            }
        }
        #endregion


    }
}
