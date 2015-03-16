using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.PropertyChanged
{
    public abstract class PropertyChangedBase:INotifyPropertyChanged
    {
        #region Implement INotifyProeprty Changed
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(String PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        #endregion
    }
}
