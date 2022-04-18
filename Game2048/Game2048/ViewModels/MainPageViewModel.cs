using Game2048.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game2048.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            GameName = "2049";
            Data = new List<TEST>();
            for (int i = 0; i < 16; i++)
            {
                Data.Add(new TEST() { test = i });
            }
            UpCommand = new DelegateCommand(UpCommandImpl);
        }

        private List<TEST> _datas;
        public List<TEST> Data
        {
            get { return _datas; }
            set { SetProperty(ref _datas, value); }
        }

        private string _2048;
        public string GameName
        {
            get { return _2048; }
            set { SetProperty(ref _2048, value); }
        }

        public DelegateCommand UpCommand { get; set; }

        public void UpCommandImpl()
        {

        }
    }
   
}
