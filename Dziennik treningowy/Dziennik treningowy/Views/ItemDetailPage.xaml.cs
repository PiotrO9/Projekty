using Dziennik_treningowy.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Dziennik_treningowy.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}