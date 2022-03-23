using MAUI_BMI_app.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_BMI_app.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            MetricClick = new Command(MetricClickImpl);
            ImperialClick = new Command(ImperialClickImpl);
            CalculateClickCommand = new Command(CalculateClickCommandImpl);

            HeightSliderValue = "30";
            MeasurementType = Measurement.metric;
        }

        public Command MetricClick { get; set; }
        public Command ImperialClick { get; set; }
        public Command CalculateClickCommand { get; set; }

        private string _heightSliderValue;
        
        public string HeightSliderValue
        {
            get { return _heightSliderValue.ToString(); }
            set { _heightSliderValue = value; OnPropertyChanged(); }
        }

        private Measurement _measurementType;

        public Measurement MeasurementType
        {
            get { return _measurementType; }
            set { _measurementType = value; OnPropertyChanged(); }
        }

        private string _heightLabelText;

        public string HeightLabelText
        {
            get 
            {
                string result = HeightSliderValue.ToString();
                switch (MeasurementType)
                {
                    case Measurement.metric:
                        {
                            result += "cm";
                            break;
                        }
                    case Measurement.imperial:
                        {
                            result += "lbs";
                            break;
                        }
                }

                return result;
            }
            private set { _heightLabelText = value; OnPropertyChanged(); }
        }


        public void MetricClickImpl()
        {

        }

        public void ImperialClickImpl()
        {
            
        }

        public void CalculateClickCommandImpl()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
