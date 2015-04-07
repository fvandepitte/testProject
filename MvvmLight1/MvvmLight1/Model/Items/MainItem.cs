using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight1.Model.Items
{
    public class MainItem : IItem
    {
        public ViewModelBase StartupModel { get; set; }
    }
}
