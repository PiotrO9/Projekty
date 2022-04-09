using LoginApp.Interface;
using LoginApp.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Rg.Plugins.Popup.Extensions;
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

        private readonly MainPage _mp;

        public MainPageViewModel(INavigationService navigationService, IUserExisting userExisting, MainPage mainPage)
            : base(navigationService)
        {
            _navigationService = navigationService;
            _userExisting = userExisting;
            _mp = mainPage;

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

            if(_userExisting.CheckUserExistence(LoginText, PasswordText))
            {
                var navigationParams = new NavigationParameters();
                navigationParams.Add("login", LoginText);
                navigationParams.Add("password", PasswordText);

                _navigationService.NavigateAsync("CorrectLoginPage", navigationParams);

                LoginText = string.Empty;
                PasswordText = string.Empty;
            }
            else
                _navigationService.NavigateAsync("WrongLoginPopUp");
        }

    }
}
