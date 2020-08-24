using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
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
                        field1.Active = true;
                        Field field2 = _listOfField.Where(w => w.X == 0 && w.Y == 4).FirstOrDefault();
                        field2.Type = TypeOfField.blueField;
                        field2.Active = true;
                        Field field3 = _listOfField.Where(w => w.X == 0 && w.Y == 5).FirstOrDefault();
                        field3.Type = TypeOfField.blueField;
                        field3.Active = true;
                        Field field4 = _listOfField.Where(w => w.X == 0 && w.Y == 6).FirstOrDefault();
                        field4.Type = TypeOfField.blueField;
                        field4.Active = true;

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

        public (int, int) GetIndex(int n)
        {
            int tempX = _oneBlockToMove[n].X;
            int tempY = _oneBlockToMove[n].Y;

            return (tempX, tempY);
        }

        public void Timer_tick()
        {
            for (int i = 0; i < 4; i++) // Ruch
            {
                int TempX;
                int TempY;

                (TempX, TempY) = GetIndex(i); // Pobranie indexu jeszcze starego pola

                IEnumerable<Field> PrevQuery = _listOfField.Where(w => w.X == TempX && w.Y == TempY);

                foreach (var item in PrevQuery)
                {
                    item.Type = TypeOfField.none;
                }

                IEnumerable<Field> query = _listOfField.Where(w => w.X == TempX + 1 && w.Y == TempY); // Lista z nowym polem po przemieszczeniu

                foreach (var item in query) // Zamiana property type na blueField czyli zmiana koloru na niebieski
                {
                    item.Type = TypeOfField.blueField;
                }
                _oneBlockToMove.RemoveAt(i); // Usunięcie oraz dodanie nowego elementu w liście z nowymi współrzędnymi
                var field = new Field(TempX + 1, TempY);
                field.Type = TypeOfField.blueField;
                _oneBlockToMove.Insert(i, field);
            }
        }



    }
}
