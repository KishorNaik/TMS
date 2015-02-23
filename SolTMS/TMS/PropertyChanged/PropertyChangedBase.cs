using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.ViewModel.PropertyChanged
{
    public class PropertyChangedBase:INotifyPropertyChanged
    {
        #region Implement INotifyProeprty Changed
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(String PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        #endregion
    }
}
