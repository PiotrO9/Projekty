using Game2048.Engines;
using Game2048.Enums;
using Game2048.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Game2048.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            GameName = "2048";
            MoveTrigger = new Command<Direction>((direction) => MoveTriggerImpl(direction));

            GenerateStartBoard generateStartBoard = new GenerateStartBoard(2, 16);

            UnpackColectionToTiles(generateStartBoard.OutputList);
        }


        #region Commands
        public Command<Direction> MoveTrigger { get; set; }

        #endregion

        #region Command Implemenation
        public void MoveTriggerImpl(Direction direction)
        {
            DirectionName = direction;
        }

        #endregion

        #region Fields

        private string _2048;
        public string GameName
        {
            get { return _2048; }
            set { SetProperty(ref _2048, value); }
        }

        private Direction _directionName;
        public Direction DirectionName
        {
            get { return _directionName; }
            set { SetProperty(ref _directionName, value); }
        }

        #region Tile Fields

        private string _firstTile;
        public string FirstTile
        {
            get { return _firstTile; }
            set { SetProperty(ref _firstTile, value); }
        }

        private string _secondTile;
        public string SecondTile
        {
            get { return _secondTile; }
            set { SetProperty(ref _secondTile, value); }
        }

        private string _thirdTile;
        public string ThirdTile
        {
            get { return _thirdTile; }
            set { SetProperty(ref _thirdTile, value); }
        }

        private string _fourthTile;
        public string FourthTile
        {
            get { return _fourthTile; }
            set { SetProperty(ref _fourthTile, value); }
        }

        private string _fifthTile;
        public string FifthTile
        {
            get { return _fifthTile; }
            set { SetProperty(ref _fifthTile, value); }
        }

        private string _sixthTile;
        public string SixthTile
        {
            get { return _sixthTile; }
            set { SetProperty(ref _sixthTile, value); }
        }

        private string _seventhTile;
        public string SeventhTile
        {
            get { return _seventhTile; }
            set { SetProperty(ref _seventhTile, value); }
        }

        private string _eighthTile;
        public string EighthTile
        {
            get { return _eighthTile; }
            set { SetProperty(ref _eighthTile, value); }
        }

        private string _ninthTile;
        public string NinthTile
        {
            get { return _ninthTile; }
            set { SetProperty(ref _ninthTile, value); }
        }

        private string _tenthTile;
        public string TenthTile
        {
            get { return _tenthTile; }
            set { SetProperty(ref _tenthTile, value); }
        }

        private string _elevenTile;
        public string ElevenTile
        {
            get { return _elevenTile; }
            set { SetProperty(ref _elevenTile, value); }
        }

        private string _twelfthTile;
        public string TwelfthTile
        {
            get { return _twelfthTile; }
            set { SetProperty(ref _twelfthTile, value); }
        }

        private string _thirteenthTile;
        public string ThirteenthTile
        {
            get { return _thirteenthTile; }
            set { SetProperty(ref _thirteenthTile, value); }
        }

        private string _fourteenTile;
        public string FourteenTile
        {
            get { return _fourteenTile; }
            set { SetProperty(ref _fourteenTile, value); }
        }

        private string _fifteenthTile;
        public string FifteenthTile
        {
            get { return _fifteenthTile; }
            set { SetProperty(ref _fifteenthTile, value); }
        }

        private string _sixteenthTile;
        public string SixteenthTile
        {
            get { return _sixteenthTile; }
            set { SetProperty(ref _sixteenthTile, value); }
        }

        #endregion

        #endregion

        #region Methods

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

        #endregion

    }

}
