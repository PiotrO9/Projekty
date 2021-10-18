﻿using Dziennik_treningowy.Models;
using Dziennik_treningowy.Models.ExercisesModels;
using Dziennik_treningowy.Services.Files_services;
using Dziennik_treningowy.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dziennik_treningowy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
            Content.BindingContext = new HistoryViewModel();        }

        private void MainCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string NameAndTxt = MainCollectionView.SelectedItem.ToString() + ".txt";

            string SelectedItemFullName = "/data/user/0/com.companyname.dziennik_treningowy/files/.local/share/trainingSaves/" + NameAndTxt;
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + "/trainingSaves";
            string[] fileEntries = Directory.GetFiles(path);

            foreach (var file in fileEntries)
            {
                if(file == SelectedItemFullName)
                {
                    List<List<Exercise>> temp = TxtToTrainingUnit.Method(path + "/" + NameAndTxt);

                    //Tu koniec, dodac nową stronę z przeglądaniem ćwiczeń
                }
            }
        }
    }
}