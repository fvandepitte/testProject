using MvvmLight1.Model.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight1.Model.Services
{
    public class DashboardService : IDataService<DashboardItem>
    {
        public void GetData(Action<DashboardItem, Exception> callback) {

            callback(new DashboardItem { SomeText = "Test" }, null);
        }
    }
}
