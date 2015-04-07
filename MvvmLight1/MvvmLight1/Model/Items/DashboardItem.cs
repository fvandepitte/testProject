using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight1.Model.Items
{
    public class DashboardItem : IItem
    {
        public List<string> Workspaces { get; set; }
    }
}
