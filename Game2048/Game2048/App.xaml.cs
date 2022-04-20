using Game2048.Engines;
using Game2048.Interfaces;
using Game2048.Services;
using Game2048.ViewModels;
using Game2048.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace Game2048
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjE4NDg0QDMyMzAyZTMxMmUzME9ETDYzQUVJb3pnVjg2L0NQaERCM3gzVmw3eHNpcE9DRHdsUkhjVVcrN0k9");
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.RegisterSingleton<IRandomNumberService, RandomNumberService>();
            containerRegistry.RegisterSingleton<IRandomRangeNumberService, RangeRandomNumberService>();

            containerRegistry.RegisterSingleton<IGenerateStartBoard, GenerateStartBoard>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }
    }
}
