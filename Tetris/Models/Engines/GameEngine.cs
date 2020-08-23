using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris.Models.Enums;

namespace Tetris.Models.Engines
{
    class GameEngine
    {
        private List<Field> _listOfField = new List<Field>();
        private List<Field> _oneBlockToMove = new List<Field>();

        public IEnumerable<PictureBox> Pictures => _listOfField.Select(s => s.Picture);

        public GameEngine()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    var field = new Field(i, j);
                    field.Type = TypeOfField.none;
                    _listOfField.Add(field);
                }
            }
        }

        public void GeneratingBlock()
        {
            Random rnd = new Random();
            int rn = 1 /*rnd.Next(1, 6)*/;

            GenerateByNumber(rn);
        }

        public void GenerateByNumber(int n)
        {
            switch (n)
            {
                case 1:
                    {
                        Field field1 = _listOfField.Where(w => w.X == 0 && w.Y == 3).FirstOrDefault();
                        field1.Type = TypeOfField.blueField;
                        Field field2 = _listOfField.Where(w => w.X == 0 && w.Y == 4).FirstOrDefault();
                        field2.Type = TypeOfField.blueField;
                        Field field3 = _listOfField.Where(w => w.X == 0 && w.Y == 5).FirstOrDefault();
                        field3.Type = TypeOfField.blueField;
                        Field field4 = _listOfField.Where(w => w.X == 0 && w.Y == 6).FirstOrDefault();
                        field4.Type = TypeOfField.blueField;

                        _oneBlockToMove.Add(field1);
                        _oneBlockToMove.Add(field2);
                        _oneBlockToMove.Add(field3);
                        _oneBlockToMove.Add(field4);
                        break;
                    }
                case 2:
                    {

                        break;
                    }
                case 3:
                    {

                        break;
                    }
                case 4:
                    {

                        break;
                    }
                case 5:
                    {

                        break;
                    }
                default:
                    break;
            }
        }


        //koniec
        public void Timer_tick()
        {


        }
    }
}
