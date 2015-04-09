using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmLight1.ViewModel
{
    public class DashboardWorkspaceViewModel : ViewModelBase
    {
        public ICommand OnEnter { get; set; }
        public ICommand OnLeave { get; set; }

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

        private bool _mouseOver;

        public bool IsMouseOver {
            get { return _mouseOver; }
            set {
                if (_mouseOver != value)
                {
                    _mouseOver = value;
                    RaisePropertyChanged<bool>(() => IsMouseOver);
                }
            }
        }
        

        public DashboardWorkspaceViewModel() {
            OnEnter = new GalaSoft.MvvmLight.Command.RelayCommand(() => { IsMouseOver = true; });
            OnLeave = new GalaSoft.MvvmLight.Command.RelayCommand(() => { IsMouseOver = false; });

        }

    }
}
