using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp.ViewModels
{
    internal class WrongLoginPopUpViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public WrongLoginPopUpViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "test";
            QuitLabelClick = new DelegateCommand(QuitLabelClickImpl);
        }

        public DelegateCommand QuitLabelClick { get; private set; }

        private void QuitLabelClickImpl()
        {
            _navigationService.GoBackAsync();
        }

    }
}
