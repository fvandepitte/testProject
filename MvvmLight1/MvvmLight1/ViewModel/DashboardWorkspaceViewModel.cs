using GalaSoft.MvvmLight;
using MvvmLight1.Model;
using MvvmLight1.Model.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Ninject;
using MvvmLight1.Model.Services;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Practices.ServiceLocation;

namespace MvvmLight1.ViewModel
{
    public class DashboardWorkspaceViewModel : ViewModelBase
    {
        private readonly IDataService<DashboardWorkspaceItem> _dataService;


        public ICommand OnEnter { get; set; }
        public ICommand OnLeave { get; set; }
        public ICommand OnClicked { get; set; }

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


        private bool _open = false;

        public bool IsOpen {
            get { return _open; }
            set {
                if (_open != value)
                {
                    _open = value;
                    RaisePropertyChanged<bool>(() => IsOpen);
                }
            }
        }

        public DashboardWorkspaceViewModel(string wsname) {
            OnEnter = new RelayCommand(() => { IsMouseOver = true; });
            OnLeave = new RelayCommand(() => { IsMouseOver = false; });
            OnClicked = new RelayCommand(() => 
            {
                foreach (var wsVM in ServiceLocator.Current.GetInstance<DashboardViewModel>().Workspaces.Where(ws => ws.Label != Label)) 
                {
                    wsVM.IsOpen = false;
                }
                IsOpen = !IsOpen; 
            });

            _dataService = new DashboardWorkspaceService(wsname);
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }
                    Label = item.Label;
                });
        }

    }
}
