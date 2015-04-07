using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight1.ViewModel
{
    public class DashboardWorkspaceViewModel : ViewModelBase
    {
        private string _label;

        public string Label {
            get { return _label; }
            set {
                if (_label != value)
                {
                    _label = value;
                    RaisePropertyChanged<string>(() => Label);
                }
            }
        }
        
    }
}
