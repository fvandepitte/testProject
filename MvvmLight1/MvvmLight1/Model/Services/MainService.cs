using Microsoft.Practices.ServiceLocation;
using MvvmLight1.Model.Items;
using MvvmLight1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight1.Model.Services
{
    public class MainService : IDataService<MainItem>
    {
        public void GetData(Action<MainItem, Exception> callback) {
            callback(new MainItem { StartupModel = ServiceLocator.Current.GetInstance<DashboardViewModel>() }, null);
        }
    }
}
