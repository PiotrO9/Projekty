using GalaSoft.MvvmLight.Command;
using HardwareInfo.Engines;
using HardwareInfo.Models.Enums;
using HardwareInfo.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HardwareInfo.Viewmodels
{
    class ButtonsClickViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        private MainWindow _mw;

        public ICommand ButtonClickCommand { get; set; }

        public ButtonsClickViewModel(MainWindow mw)
        {
            _mw = mw;
            ButtonClickCommand = new RelayCommand(ButtonClickCommandImpl);
        }

        public void ButtonClickCommandImpl()
        {
            CurrentPageEnum currentPageEnum = _mw.currentPageEnum;

            switch (currentPageEnum)
            {
                case CurrentPageEnum.none:
                    {
                        
                        break;
                    }
                case CurrentPageEnum.CPU:
                    {
                        UnlockButtons ub = new UnlockButtons(_mw);
                        ub.UnlockButtonsMehod();
                        _mw.CpuButton.IsEnabled = false;
                        break;
                    }
                case CurrentPageEnum.GPU:
                    {
                        UnlockButtons ub = new UnlockButtons(_mw);
                        ub.UnlockButtonsMehod();
                        _mw.GpuButton.IsEnabled = false;
                        break;
                    }
                case CurrentPageEnum.RAM:
                    {
                        UnlockButtons ub = new UnlockButtons(_mw);
                        ub.UnlockButtonsMehod();
                        _mw.RAMButton.IsEnabled = false;
                        break;
                    }
                case CurrentPageEnum.MEMORY:
                    {
                        UnlockButtons ub = new UnlockButtons(_mw);
                        ub.UnlockButtonsMehod();
                        _mw.MemoryButton.IsEnabled = false;
                        break;
                    }
                case CurrentPageEnum.BIOS:
                    {
                        UnlockButtons ub = new UnlockButtons(_mw);
                        ub.UnlockButtonsMehod();
                        _mw.BiosButton.IsEnabled = false;

                        BIOSPage BiosPage = new BIOSPage();
                        _mw.MainFrame.Content = BiosPage;

                        break;
                    }
                case CurrentPageEnum.OS:
                    {
                        UnlockButtons ub = new UnlockButtons(_mw);
                        ub.UnlockButtonsMehod();
                        _mw.OsButton.IsEnabled = false;
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
