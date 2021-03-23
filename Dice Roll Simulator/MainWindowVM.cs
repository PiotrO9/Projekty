using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Media.Media3D;

namespace Dice_Roll_Simulator
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public static Color Color { get; set; } = Color.FromArgb(255, 255, 0);


        private Material _mainCubeMaterial;

        public Material MainCubeMaterial
        {
            get { return _mainCubeMaterial; }
            set { _mainCubeMaterial = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }



    }
}
