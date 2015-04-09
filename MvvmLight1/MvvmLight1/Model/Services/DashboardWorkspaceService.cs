using MvvmLight1.Model.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace MvvmLight1.Model.Services
{
    public class DashboardWorkspaceService : IDataService<DashboardWorkspaceItem>
    {
        private string _wsname;
        
        public DashboardWorkspaceService(string wsName) {
            _wsname = wsName;
        }

        public void GetData(Action<DashboardWorkspaceItem, Exception> callback) {

            callback(new DashboardWorkspaceItem() { Label = _wsname }, null);

        }
    }
}
