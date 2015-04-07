using GalaSoft.MvvmLight;
using MvvmLight1.Model;
using MvvmLight1.Model.Items;
using System.Collections.ObjectModel;

namespace MvvmLight1.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class DashboardViewModel : ViewModelBase
    {
        private readonly IDataService<DashboardItem> _dataService;

        private string _someText;

        public string SomeText {
            get { return _someText; }
            set {
                if (_someText != value)
                {
                    _someText = value;
                    RaisePropertyChanged<string>(() => SomeText);
                }
            }
        }

        private ObservableCollection<DashboardWorkspaceViewModel> _workspaces;

        public ObservableCollection<DashboardWorkspaceViewModel> Workspaces {
            get { return _workspaces; }
            set {
                if (_workspaces != value)
                {
                    _workspaces = value;
                    RaisePropertyChanged<ObservableCollection<DashboardWorkspaceViewModel>>(() => Workspaces);
                }
            }
        }
        

        /// <summary>
        /// Initializes a new instance of the DashboardViewModel class.
        /// </summary>
        public DashboardViewModel(IDataService<DashboardItem> dataService) {
            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    SomeText = item.SomeText;
                });
        }
    }
}