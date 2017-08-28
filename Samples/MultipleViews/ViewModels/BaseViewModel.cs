﻿using System.Collections.Generic;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using Template10.Common;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;

namespace Sample.ViewModels
{
    public class BaseViewModel:ViewModelBase, INavigable
    {
        public virtual Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            return Task.CompletedTask;
        }

        public virtual Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            return Task.CompletedTask;
        }

        public virtual Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            return Task.CompletedTask;
        }

        public INavigationService NavigationService { get; set; }
        public IDispatcherWrapper Dispatcher { get; set; }
        public IStateItems SessionState { get; set; }
    }
}
