using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LoginApp.ViewModels
{
    class MasterDetailCorrectLoginPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public MasterDetailCorrectLoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
        }

        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }
    }
}
