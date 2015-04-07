using MvvmLight1.Model.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvvmLight1.Model
{
    public interface IDataService<T>
        where T : IItem
    {
        void GetData(Action<T, Exception> callback);
    }
}
