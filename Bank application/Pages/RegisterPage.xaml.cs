﻿using Bank_application.services;
using Bank_application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bank_application.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        private MainWindow _mw;

        private RegisterPageVM _vm;

        private int _AccountNnumber { get; set; }

        public RegisterPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mw = mainWindow;
            _AccountNnumber = GenerateAccountNumber.Method(_mw);
            this.AccountNumberLabelOutput.Content = _AccountNnumber;
            _vm = new RegisterPageVM(_mw,this);
            _mw.DataContext = _vm;
        }
    }
}
