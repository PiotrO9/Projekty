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

            AddWeightClickCommand = new Command(AddWeightClickCommandImpl);
            SubWeightClickCommand = new Command(SubWeightClickCommandImpl);
            AddAgeClickCommand = new Command(AddAgeClickCommandImpl);
            SubAgeClickCommand = new Command(SubAgeClickCommandImpl);

            HeightSliderValue = "150";
            MeasurementType = Measurement.metric;

            AgeAmount = 20;
            WeightAmount = 60;
        }

        #region Commands

        public Command MetricClick { get; set; }
        public Command ImperialClick { get; set; }
        public Command CalculateClickCommand { get; set; }


        public Command AddWeightClickCommand { get; set; }
        public Command SubWeightClickCommand { get; set; }

        public Command AddAgeClickCommand { get; set; }
        public Command SubAgeClickCommand { get; set; }

        #endregion

        #region Fields

        private string _heightSliderValue;
        
        public string HeightSliderValue
        {
            get { return _heightSliderValue.ToString(); }
            set { _heightSliderValue = value; HeightLabelText = CombineHieghtLabelText(); OnPropertyChanged(); }
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
            get { return _heightLabelText; }
            private set { _heightLabelText = value; OnPropertyChanged(); }
        }

        private int _weightAmount;

        public int WeightAmount
        {
            get { return _weightAmount; }
            set { _weightAmount = value; OnPropertyChanged(); }
        }

        private int _ageAmount;

        public int AgeAmount
        {
            get { return _ageAmount; }
            set { _ageAmount = value; OnPropertyChanged(); }
        }

        public string TemporaryMeasurementTypeName
        {
            get { return MeasurementType.ToString(); }
            set { TemporaryMeasurementTypeName = value; OnPropertyChanged(); }
        }

        #endregion

        #region CommandsImplemenattion

        public void MetricClickImpl()
        {
            MeasurementType = Measurement.metric;
        }

        public void ImperialClickImpl()
        {
            MeasurementType = Measurement.imperial;
        }

        public void CalculateClickCommandImpl()
        {

        }

        public void AddWeightClickCommandImpl()
        {
            ChangeWeightValue(ChangeDirection.Add);
        }

        public void SubWeightClickCommandImpl()
        {
            ChangeWeightValue(ChangeDirection.Sub);
        }

        public void AddAgeClickCommandImpl()
        {
            ChangeAgeValue(ChangeDirection.Add);
        }

        public void SubAgeClickCommandImpl()
        {
            ChangeAgeValue(ChangeDirection.Sub);
        }

        #endregion

        public string CombineHieghtLabelText()
        {
            string result = HeightSliderValue.ToString();
            switch (MeasurementType)
            {
                case Measurement.metric:
                    {
                        result += " cm";
                        break;
                    }
                case Measurement.imperial:
                    {
                        result += " lbs";
                        break;
                    }
                default:
                    {
                        result += " cm";
                        break;
                    }
            }

            return result;
        }

        public void ChangeWeightValue(ChangeDirection changeDirection)
        {
            switch (MeasurementType)
            {
                case Measurement.metric:
                    {
                        if (changeDirection == ChangeDirection.Add)
                        {
                            if (WeightAmount == 150)
                                break;
                            else
                                WeightAmount++;
                        }    
                        else
                        {
                            if (WeightAmount == 30)
                                break;
                            else
                                WeightAmount--;
                        }
                            
                    break;
                    }
                case Measurement.imperial:
                    {
                        if (changeDirection == ChangeDirection.Add)
                        {
                            if (WeightAmount == 330)
                                break;
                            else
                                WeightAmount++;
                        }
                        else
                        {
                            if (WeightAmount == 66)
                                break;
                            else
                                WeightAmount--;
                        }

                        break;
                    }
                    
            }
        }

        public void ChangeAgeValue(ChangeDirection changeDirection)
        {
            if (changeDirection == ChangeDirection.Add)
            {
                if (AgeAmount == 99)
                    return;
                else
                    AgeAmount++;
            }
            else
            {
                if (AgeAmount == 10)
                    return;
                else
                    AgeAmount--;
            }
        }

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
