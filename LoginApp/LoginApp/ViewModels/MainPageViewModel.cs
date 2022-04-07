using LoginApp.Interface;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LoginApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        private readonly IUserExisting _userExisting;

        public MainPageViewModel(INavigationService navigationService, IUserExisting userExisting)
            : base(navigationService)
        {
            _navigationService = navigationService;
            _userExisting = userExisting;

            Title = "Main Page";
            LoadingTextAvailable = false;
            LoginClickCommand = new DelegateCommand(LoginClickCommandImpl);
        }

        #region Properties

        private string _loginText;
        public string LoginText
        {
            get { return _loginText; }
            set { SetProperty(ref _loginText, value); }
        }

        private string _passwordText;
        public string PasswordText
        {
            get { return _passwordText; }
            set { SetProperty(ref _passwordText, value); }
        }

        private bool _loadingTextAvailable;
        public bool LoadingTextAvailable
        {
            get { return _loadingTextAvailable; }
            set { SetProperty(ref _loadingTextAvailable, value); }
        }

        #endregion

        public DelegateCommand LoginClickCommand { get; private set; }

        private void LoginClickCommandImpl()
        {
            if (String.IsNullOrWhiteSpace(LoginText))
                return;
            if (String.IsNullOrWhiteSpace(PasswordText))
                return;

            LoadingTextAvailable = false;

            bool temp = _userExisting.CheckUserExistence(LoginText, PasswordText);

            LoadingTextAvailable = true;
        }

    }
}
