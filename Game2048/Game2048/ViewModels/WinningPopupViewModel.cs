using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Game2048.ViewModels
{
    class WinningPopupViewModel : ViewModelBase, INavigationAware, INavigatedAware
    {
        private readonly INavigationService _navigationService;

        private MainPageViewModel _mainPageViewModel;

        public WinningPopupViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;

            RestartClickCommand = new DelegateCommand(RestartClickCommandImpl);
            ContinueClickCommand = new DelegateCommand(ContinueClickCommandImpl);
        }

        public DelegateCommand RestartClickCommand { get; set; }
        public DelegateCommand ContinueClickCommand { get; set; }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            _mainPageViewModel = parameters.GetValue<MainPageViewModel>("ViewModel");
            _mainPageViewModel.PlayingOver2048 = true;
        }

        private async void RestartClickCommandImpl()
        {
            _mainPageViewModel.RestartGame();
            await _navigationService.NavigateAsync("MainPage");
        }

        private async void ContinueClickCommandImpl()
        {
            _mainPageViewModel.PlayingOver2048 = true;
            await _navigationService.GoBackAsync();
        }
    }
}
