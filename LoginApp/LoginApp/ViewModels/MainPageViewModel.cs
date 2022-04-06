using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoginApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            LoginClickCommand = new DelegateCommand(LoginClickCommandImpl);
        }

        public DelegateCommand LoginClickCommand { get; private set; }

        private void LoginClickCommandImpl()
        {

        }

    }
}
