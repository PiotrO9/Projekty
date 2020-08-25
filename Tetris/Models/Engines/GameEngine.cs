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

        int CurrentBlockNumber;

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
            int rn = rnd.Next(1, 4);

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

                        CurrentBlockNumber = 1;
                        break;
                    }
                case 2:
                    {
                        Field field1 = _listOfField.Where(w => w.X == 0 && w.Y == 4).FirstOrDefault();
                        field1.Type = TypeOfField.greenField;
                        field1.Active = true;
                        Field field2 = _listOfField.Where(w => w.X == 0 && w.Y == 5).FirstOrDefault();
                        field2.Type = TypeOfField.greenField;
                        field2.Active = true;
                        Field field3 = _listOfField.Where(w => w.X == 1 && w.Y == 4).FirstOrDefault();
                        field3.Type = TypeOfField.greenField;
                        field3.Active = true;
                        Field field4 = _listOfField.Where(w => w.X == 1 && w.Y == 5).FirstOrDefault();
                        field4.Type = TypeOfField.greenField;
                        field4.Active = true;

                        _oneBlockToMove.Add(field1);
                        _oneBlockToMove.Add(field2);
                        _oneBlockToMove.Add(field3);
                        _oneBlockToMove.Add(field4);

                        CurrentBlockNumber = 2;
                        break;
                    }
                case 3:
                    {
                        Field field1 = _listOfField.Where(w => w.X == 1 && w.Y == 3).FirstOrDefault();
                        field1.Type = TypeOfField.orangeField;
                        field1.Active = true;
                        Field field2 = _listOfField.Where(w => w.X == 1 && w.Y == 4).FirstOrDefault();
                        field2.Type = TypeOfField.orangeField;
                        field2.Active = true;
                        Field field3 = _listOfField.Where(w => w.X == 0 && w.Y == 4).FirstOrDefault();
                        field3.Type = TypeOfField.orangeField;
                        field3.Active = true;
                        Field field4 = _listOfField.Where(w => w.X == 0 && w.Y == 5).FirstOrDefault();
                        field4.Type = TypeOfField.orangeField;
                        field4.Active = true;

                        _oneBlockToMove.Add(field1);
                        _oneBlockToMove.Add(field2);
                        _oneBlockToMove.Add(field3);
                        _oneBlockToMove.Add(field4);

                        CurrentBlockNumber = 3;
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
            if (CheckingColision(1) == true && CurrentBlockNumber == 1)
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
            else if (CheckingColision(2) == true && CurrentBlockNumber == 2)
            {
                for (int i = 3; i > -1; i--)
                {
                    int TempX;
                    int TempY;

                    (TempX, TempY) = GetIndex(i);

                    IEnumerable<Field> PrevQuery = _listOfField.Where(w => w.X == TempX && w.Y == TempY);

                    foreach (var item in PrevQuery)
                    {
                        item.Type = TypeOfField.none;
                    }

                    IEnumerable<Field> query = _listOfField.Where(w => w.X == TempX + 1 && w.Y == TempY);

                    foreach (var item in query)
                    {
                        item.Type = TypeOfField.greenField;
                    }
                    _oneBlockToMove.RemoveAt(i);
                    var field = new Field(TempX + 1, TempY);
                    field.Type = TypeOfField.greenField;
                    _oneBlockToMove.Insert(i, field);
                }
            }
            else if (CheckingColision(3) == true && CurrentBlockNumber == 3)
            {
                for (int i = 0; i < 4; i++) // Ruch
                {
                    int TempX;
                    int TempY;

                    (TempX, TempY) = GetIndex(i);

                    IEnumerable<Field> PrevQuery = _listOfField.Where(w => w.X == TempX && w.Y == TempY);

                    foreach (var item in PrevQuery)
                    {
                        item.Type = TypeOfField.none;
                    }

                    IEnumerable<Field> query = _listOfField.Where(w => w.X == TempX + 1 && w.Y == TempY);

                    foreach (var item in query)
                    {
                        item.Type = TypeOfField.orangeField;
                    }
                    _oneBlockToMove.RemoveAt(i);
                    var field = new Field(TempX + 1, TempY);
                    field.Type = TypeOfField.orangeField;
                    _oneBlockToMove.Insert(i, field);
                }
            }
            else
            {
                foreach (var item in _oneBlockToMove)
                {
                    item.Active = false;
                }

                _oneBlockToMove.Clear();
                CurrentBlockNumber = 0;
                GeneratingBlock();
            }
        }


        public bool CheckingColision(int n) //true - ruch możliwy, false - kolizja czyli ruch niemożliwy
        {
            int TempX;
            int TempY;

            if (n == 1)
            {
                int temp = 0;

                for (int i = 0; i < 4; i++)
                {
                    (TempX, TempY) = GetIndex(i);
                    if (TempX + 1 >= 20)
                    {
                        return false; // sprawdzenie czy znajdujemy się na samym dole czyli indexie x == 19
                    }

                    Field query = _listOfField.Where(w => w.X == TempX + 1 && w.Y == TempY).FirstOrDefault();

                    if (query.Type == TypeOfField.none)
                    {
                        temp++; // sprawdzenie czy pole pod nami to pole już zajęte
                    }
                }

                if (temp == 4)
                {
                    return true;
                }

            }
            else if (n == 2)
            {
                int temp = 0;

                for (int i = 2; i < 4; i++)
                {
                    (TempX, TempY) = GetIndex(i);
                    if (TempX + 1 >= 20)
                    {
                        return false;
                    }
                    Field query = _listOfField.Where(w => w.X == TempX + 1 && w.Y == TempY).FirstOrDefault();

                    if (query.Type == TypeOfField.none)
                    {
                        temp++;
                    }
                }

                if (temp == 2)
                {
                    return true;
                }
            }
            else if (n == 3) // Koniec , dodaj sprawdzanie bloku wyżej
            {
                int temp = 0;

                for (int i = 0; i < 2; i++)
                {
                    (TempX, TempY) = GetIndex(i);
                    if (TempX + 1 >= 20)
                    {
                        return false;
                    }
                    Field query = _listOfField.Where(w => w.X == TempX + 1 && w.Y == TempY).FirstOrDefault();

                    if (query.Type == TypeOfField.none)
                    {
                        temp++;
                    }
                }

                if (temp == 2)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
