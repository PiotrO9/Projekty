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
using To_do_list.Pages;

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

                        CPUPage CPUPage = new CPUPage();
                        _mw.MainFrame.Content = CPUPage;
                        break;
                    }
                case CurrentPageEnum.GPU:
                    {
                        UnlockButtons ub = new UnlockButtons(_mw);
                        ub.UnlockButtonsMehod();
                        _mw.GpuButton.IsEnabled = false;

                        GPUPage GPUPage = new GPUPage();
                        _mw.MainFrame.Content = GPUPage;
                        break;
                    }
                case CurrentPageEnum.RAM:
                    {
                        UnlockButtons ub = new UnlockButtons(_mw);
                        ub.UnlockButtonsMehod();
                        _mw.RAMButton.IsEnabled = false;

                        RAMPage RAMPage = new RAMPage();
                        _mw.MainFrame.Content = RAMPage;
                        break;
                    }
                case CurrentPageEnum.MEMORY:
                    {
                        UnlockButtons ub = new UnlockButtons(_mw);
                        ub.UnlockButtonsMehod();
                        _mw.MemoryButton.IsEnabled = false;

                        MemoryPage MemoryPage = new MemoryPage();
                        _mw.MainFrame.Content = MemoryPage;
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

                        OSPage oSPage = new OSPage();
                        _mw.MainFrame.Content = oSPage;
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
