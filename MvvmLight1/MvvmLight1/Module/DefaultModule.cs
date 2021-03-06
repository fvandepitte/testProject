﻿using GalaSoft.MvvmLight;
using MvvmLight1.Model;
using MvvmLight1.Model.Items;
using MvvmLight1.Model.Services;
using MvvmLight1.ViewModel;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight1.Module
{
    public class DefaultModule : NinjectModule
    {
        public override void Load() {

            Bind<MainViewModel>().ToSelf().InSingletonScope();
            Bind<DashboardViewModel>().ToSelf().InSingletonScope();

        }
    }
}
