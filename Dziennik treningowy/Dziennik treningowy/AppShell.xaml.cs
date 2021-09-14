using Dziennik_treningowy.ViewModels;
using Dziennik_treningowy.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Dziennik_treningowy
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
