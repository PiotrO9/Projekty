using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailCorrectLoginPage : IMasterDetailPageOptions
    {
        public static readonly BindableProperty IsPresentedAfterNavigationProperty =
            BindableProperty.Create(nameof(IsPresentedAfterNavigation), typeof(bool), typeof(MasterDetailCorrectLoginPage), false);

        public MasterDetailCorrectLoginPage()
        {
            InitializeComponent();
        }

        public bool IsPresentedAfterNavigation
        {
            get => (bool)GetValue(IsPresentedAfterNavigationProperty);
            set => SetValue(IsPresentedAfterNavigationProperty, value);
        }
    }
}