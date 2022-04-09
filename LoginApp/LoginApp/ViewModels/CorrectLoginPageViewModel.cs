using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp.ViewModels
{
    internal class CorrectLoginPageViewModel : ViewModelBase, INavigationAware, INavigatedAware
    {
        private readonly INavigationService _navigationService;

        public CorrectLoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
        }

        private string _login;
        public string Login
        {
            get { return _login; }
            set { SetProperty(ref _login, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        #region INavigationAware

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Login = parameters.GetValue<string>("login");
            Password = parameters.GetValue<string>("password");
        }

        #endregion
    }
}
