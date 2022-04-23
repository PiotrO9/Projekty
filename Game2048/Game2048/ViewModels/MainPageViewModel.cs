using Game2048.Engines;
using Game2048.Enums;
using Game2048.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Game2048.ViewModels
{
    public class MainPageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            GameName = "2048";
            MoveTrigger = new Command<Direction>((direction) => MoveTriggerImpl(direction));

            GenerateStartBoard generateStartBoard = new GenerateStartBoard(2, 4);

            UnpackColectionToTiles(generateStartBoard.OutputList);
            UpdateTilesBackgroundColors();
        }

        #region Commands
        public Command<Direction> MoveTrigger { get; set; }

        #endregion

        #region Command Implemenation
        public void MoveTriggerImpl(Direction direction)
        {
            DirectionName = direction;
            MoveEngine moveEngine = new MoveEngine(PackTilesToColection(), direction);
            UnpackColectionToTiles(moveEngine.MovedList);
            UpdateTilesBackgroundColors();
        }

        #endregion

        #region Fields

        private string _2048;
        public string GameName
        {
            get { return _2048; }
            set { SetProperty(ref _2048, value); OnPropertyChanged(); }
        }

        private Direction _directionName;
        public Direction DirectionName
        {
            get { return _directionName; }
            set { SetProperty(ref _directionName, value); OnPropertyChanged(); }
        }

        #region Tile Fields

        #region Tile text

        private string _firstTile;
        public string FirstTile
        {
            get { return _firstTile; }
            set { SetProperty(ref _firstTile, value); OnPropertyChanged(); }
        }

        private string _secondTile;
        public string SecondTile
        {
            get { return _secondTile; }
            set { SetProperty(ref _secondTile, value); OnPropertyChanged(); }
        }

        private string _thirdTile;
        public string ThirdTile
        {
            get { return _thirdTile; }
            set { SetProperty(ref _thirdTile, value); OnPropertyChanged(); }
        }

        private string _fourthTile;
        public string FourthTile
        {
            get { return _fourthTile; }
            set { SetProperty(ref _fourthTile, value); OnPropertyChanged(); }
        }

        private string _fifthTile;
        public string FifthTile
        {
            get { return _fifthTile; }
            set { SetProperty(ref _fifthTile, value); OnPropertyChanged(); }
        }

        private string _sixthTile;
        public string SixthTile
        {
            get { return _sixthTile; }
            set { SetProperty(ref _sixthTile, value); OnPropertyChanged(); }
        }

        private string _seventhTile;
        public string SeventhTile
        {
            get { return _seventhTile; }
            set { SetProperty(ref _seventhTile, value); OnPropertyChanged(); }
        }

        private string _eighthTile;
        public string EighthTile
        {
            get { return _eighthTile; }
            set { SetProperty(ref _eighthTile, value); OnPropertyChanged(); }
        }

        private string _ninthTile;
        public string NinthTile
        {
            get { return _ninthTile; }
            set { SetProperty(ref _ninthTile, value); OnPropertyChanged(); }
        }

        private string _tenthTile;
        public string TenthTile
        {
            get { return _tenthTile; }
            set { SetProperty(ref _tenthTile, value); OnPropertyChanged(); }
        }

        private string _elevenTile;
        public string ElevenTile
        {
            get { return _elevenTile; }
            set { SetProperty(ref _elevenTile, value); OnPropertyChanged(); }
        }

        private string _twelfthTile;
        public string TwelfthTile
        {
            get { return _twelfthTile; }
            set { SetProperty(ref _twelfthTile, value); OnPropertyChanged(); }
        }

        private string _thirteenthTile;
        public string ThirteenthTile
        {
            get { return _thirteenthTile; }
            set { SetProperty(ref _thirteenthTile, value); OnPropertyChanged(); }
        }

        private string _fourteenTile;
        public string FourteenTile
        {
            get { return _fourteenTile; }
            set { SetProperty(ref _fourteenTile, value); OnPropertyChanged(); }
        }

        private string _fifteenthTile;
        public string FifteenthTile
        {
            get { return _fifteenthTile; }
            set { SetProperty(ref _fifteenthTile, value); OnPropertyChanged(); }
        }

        private string _sixteenthTile;
        public string SixteenthTile
        {
            get { return _sixteenthTile; }
            set { SetProperty(ref _sixteenthTile, value); OnPropertyChanged(); }
        }

        #endregion

        #region Tile font size

        private int _firstTileFontsize;
        public int FirstTileFontsize
        {
            get { return _firstTileFontsize; }
            set { SetProperty(ref _firstTileFontsize, value); OnPropertyChanged(); }
        }

        private int _secondTileFontsize;
        public int SecondTileFontsize
        {
            get { return _secondTileFontsize; }
            set { SetProperty(ref _secondTileFontsize, value); OnPropertyChanged(); }
        }

        private int _thirdTileFontsize;
        public int ThirdTileFontsize
        {
            get { return _thirdTileFontsize; }
            set { SetProperty(ref _thirdTileFontsize, value); OnPropertyChanged(); }
        }

        private int _fourthTileFontsize;
        public int FourthTileFontsize
        {
            get { return _fourthTileFontsize; }
            set { SetProperty(ref _fourthTileFontsize, value); OnPropertyChanged(); }
        }

        private int _fifthTileFontsize;
        public int FifthTileFontsize
        {
            get { return _fifthTileFontsize; }
            set { SetProperty(ref _fifthTileFontsize, value); OnPropertyChanged(); }
        }

        private int _sixthTileFontsize;
        public int SixthTileFontsize
        {
            get { return _sixthTileFontsize; }
            set { SetProperty(ref _sixthTileFontsize, value); OnPropertyChanged(); }
        }

        private int _seventhTileFontsize;
        public int SeventhTileFontsize
        {
            get { return _seventhTileFontsize; }
            set { SetProperty(ref _seventhTileFontsize, value); OnPropertyChanged(); }
        }

        private int _eighthTileFontsize;
        public int EighthTileFontsize
        {
            get { return _eighthTileFontsize; }
            set { SetProperty(ref _eighthTileFontsize, value); OnPropertyChanged(); }
        }

        private int _ninthTileFontsize;
        public int NinthTileFontsize
        {
            get { return _ninthTileFontsize; }
            set { SetProperty(ref _ninthTileFontsize, value); OnPropertyChanged(); }
        }

        private int _tenthTileFontsize;
        public int TenthTileFontsize
        {
            get { return _tenthTileFontsize; }
            set { SetProperty(ref _tenthTileFontsize, value); OnPropertyChanged(); }
        }

        private int _eleventhTileFontsize;
        public int EleventhTileFontsize
        {
            get { return _eleventhTileFontsize; }
            set { SetProperty(ref _eleventhTileFontsize, value); OnPropertyChanged(); }
        }

        private int _twelfthTileFontsize;
        public int TwelfthTileFontsize
        {
            get { return _twelfthTileFontsize; }
            set { SetProperty(ref _twelfthTileFontsize, value); OnPropertyChanged(); }
        }

        private int _thirteenthTileFontsize;
        public int ThirteenthTileFontsize
        {
            get { return _thirteenthTileFontsize; }
            set { SetProperty(ref _thirteenthTileFontsize, value); OnPropertyChanged(); }
        }

        private int _fourteenthTileFontsize;
        public int FourteenthTileFontsize
        {
            get { return _fourteenthTileFontsize; }
            set { SetProperty(ref _fourteenthTileFontsize, value); OnPropertyChanged(); }
        }

        private int _fifteenthTileFontsize;
        public int FifteenthTileFontsize
        {
            get { return _fifteenthTileFontsize; }
            set { SetProperty(ref _fifteenthTileFontsize, value); OnPropertyChanged(); }
        }

        private int _sixteenthTileFontsize;
        public int SixteenthTileFontsize
        {
            get { return _sixteenthTileFontsize; }
            set { SetProperty(ref _sixteenthTileFontsize, value); OnPropertyChanged(); }
        }

        #endregion

        #region Background color name

        private string _firstTileBackgroundColor;
        public string FirstTileBackgroundColor
        {
            get { return _firstTileBackgroundColor; }
            set { SetProperty(ref _firstTileBackgroundColor, value); OnPropertyChanged(); }
        }

        private string _secondTileBackgroundColor;
        public string SecondTileBackgroundColor
        {
            get { return _secondTileBackgroundColor; }
            set { SetProperty(ref _secondTileBackgroundColor, value); OnPropertyChanged(); }
        }

        private string _thirdTileBackgroundColor;
        public string ThirdTileBackgroundColor
        {
            get { return _thirdTileBackgroundColor; }
            set { SetProperty(ref _thirdTileBackgroundColor, value); OnPropertyChanged(); }
        }

        private string _fourthTileBackgroundColor;
        public string FourthTileBackgroundColor
        {
            get { return _fourthTileBackgroundColor; }
            set { SetProperty(ref _fourthTileBackgroundColor, value); OnPropertyChanged(); }
        }

        private string _fifthTileBackgroundColor;
        public string FifthTileBackgroundColor
        {
            get { return _fifthTileBackgroundColor; }
            set { SetProperty(ref _fifthTileBackgroundColor, value); OnPropertyChanged(); }
        }

        private string _sixthTileBackgroundColor;
        public string SixthTileBackgroundColor
        {
            get { return _sixthTileBackgroundColor; }
            set { SetProperty(ref _sixthTileBackgroundColor, value); OnPropertyChanged(); }
        }

        private string _seventhTileBackgroundColor;
        public string SeventhTileBackgroundColor
        {
            get { return _seventhTileBackgroundColor; }
            set { SetProperty(ref _seventhTileBackgroundColor, value); OnPropertyChanged(); }
        }

        private string _eighthTileBackgroundColor;
        public string EighthTileBackgroundColor
        {
            get { return _eighthTileBackgroundColor; }
            set { SetProperty(ref _eighthTileBackgroundColor, value); OnPropertyChanged(); }
        }

        private string _ninthTileBackgroundColor;
        public string NinthTileBackgroundColor
        {
            get { return _ninthTileBackgroundColor; }
            set { SetProperty(ref _ninthTileBackgroundColor, value); OnPropertyChanged(); }
        }

        private string _tenthTileBackgroundColor;
        public string TenthTileBackgroundColor
        {
            get { return _tenthTileBackgroundColor; }
            set { SetProperty(ref _tenthTileBackgroundColor, value); OnPropertyChanged(); }
        }

        private string _eleventhTileBackgroundColor;
        public string EleventhTileBackgroundColor
        {
            get { return _eleventhTileBackgroundColor; }
            set { SetProperty(ref _eleventhTileBackgroundColor, value); OnPropertyChanged(); }
        }

        private string _twelfthTileBackgroundColor;
        public string TwelfthTileBackgroundColor
        {
            get { return _twelfthTileBackgroundColor; }
            set { SetProperty(ref _twelfthTileBackgroundColor, value); OnPropertyChanged(); }
        }

        private string _thirteenthTileBackgroundColor;
        public string ThirteenthTileBackgroundColor
        {
            get { return _thirteenthTileBackgroundColor; }
            set { SetProperty(ref _thirteenthTileBackgroundColor, value); OnPropertyChanged(); }
        }

        private string _fourteenthTileBackgroundColor;
        public string FourteenthTileBackgroundColor
        {
            get { return _fourteenthTileBackgroundColor; }
            set { SetProperty(ref _fourteenthTileBackgroundColor, value); OnPropertyChanged(); }
        }

        private string _fifteenthTileBackgroundColor;
        public string FifteenthTileBackgroundColor
        {
            get { return _fifteenthTileBackgroundColor; }
            set { SetProperty(ref _fifteenthTileBackgroundColor, value); OnPropertyChanged(); }
        }

        private string _sixteenthTileBackgroundColor;
        public string SixteenthTileBackgroundColor
        {
            get { return _sixteenthTileBackgroundColor; }
            set { SetProperty(ref _sixteenthTileBackgroundColor, value); OnPropertyChanged(); }
        }

        #endregion

        #endregion

        #endregion

        #region Methods

        private void UpdateTilesBackgroundColors()
        {
            FirstTileBackgroundColor = SetBackgroundColorForTile(FirstTile);
            SecondTileBackgroundColor = SetBackgroundColorForTile(SecondTile);
            ThirdTileBackgroundColor = SetBackgroundColorForTile(ThirdTile);
            FourthTileBackgroundColor = SetBackgroundColorForTile(FourthTile);
            FifthTileBackgroundColor = SetBackgroundColorForTile(FifthTile);
            SixthTileBackgroundColor = SetBackgroundColorForTile(SixthTile);
            SeventhTileBackgroundColor = SetBackgroundColorForTile(SeventhTile);
            EighthTileBackgroundColor = SetBackgroundColorForTile(EighthTile);
            NinthTileBackgroundColor = SetBackgroundColorForTile(NinthTile);
            TenthTileBackgroundColor = SetBackgroundColorForTile(TenthTile);
            EleventhTileBackgroundColor = SetBackgroundColorForTile(ElevenTile);
            TwelfthTileBackgroundColor = SetBackgroundColorForTile(TwelfthTile);
            ThirteenthTileBackgroundColor = SetBackgroundColorForTile(ThirteenthTile);
            FourteenthTileBackgroundColor = SetBackgroundColorForTile(FourteenTile);
            FifteenthTileBackgroundColor = SetBackgroundColorForTile(FifteenthTile);
            SixteenthTileBackgroundColor = SetBackgroundColorForTile(SixteenthTile);
        }

        private List<string> PackTilesToColection()
        {
            List<string> ResultList = new List<string>();
            ResultList.Add(FirstTile);
            ResultList.Add(SecondTile);
            ResultList.Add(ThirdTile);
            ResultList.Add(FourthTile);

            ResultList.Add(FifthTile);
            ResultList.Add(SixthTile);
            ResultList.Add(SeventhTile);
            ResultList.Add(EighthTile);

            ResultList.Add(NinthTile);
            ResultList.Add(TenthTile);
            ResultList.Add(ElevenTile);
            ResultList.Add(TwelfthTile);

            ResultList.Add(ThirteenthTile);
            ResultList.Add(FourteenTile);
            ResultList.Add(FifteenthTile);
            ResultList.Add(SixteenthTile);

            return ResultList;
        }

        private void UnpackColectionToTiles(List<string> InputList)
        {
            if (InputList.Count != 16)
                throw new Exception();

            FirstTile = InputList[0];
            SecondTile = InputList[1];
            ThirdTile = InputList[2];
            FourthTile = InputList[3];
            FifthTile = InputList[4];
            SixthTile = InputList[5];
            SeventhTile = InputList[6];
            EighthTile = InputList[7];
            NinthTile = InputList[8];
            TenthTile = InputList[9];
            ElevenTile = InputList[10];
            TwelfthTile = InputList[11];
            ThirteenthTile = InputList[12];
            FourteenTile = InputList[13];
            FifteenthTile = InputList[14];
            SixteenthTile = InputList[15];
        }

        private string SetBackgroundColorForTile(string TileText)
        {
            switch (TileText)
            {
                case "0":
                    {
                        return "#FFFFFF";
                    }
                case "2":
                    {
                        return "#342C25";
                    }
                case "4":
                    {
                        return "#372F1C";
                    }
                case "8":
                    {
                        return "#F3B27A";
                    }
                case "16":
                    {
                        return "#F69664";
                    }
                case "32":
                    {
                        return "#F77C5F";
                    }
                case "64":
                    {
                        return "#F75F3B";
                    }
                case "128":
                    {
                        return "#4B3B00";
                    }
                case "256":
                    {
                        return "#EDCC62";
                    }
                case "512":
                    {
                        return "#EDC950";
                    }
                case "1024":
                    {
                        return "#E7C258";
                    }
                case "2048":
                    {
                        return "#E8BE4E";
                    }
                default:
                    {
                        return "#E8BE4E";
                    }
            }
        }

        #endregion

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
