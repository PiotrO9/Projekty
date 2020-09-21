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
        int points;
        int AmountOfRows;

        int[] ArrayOfColors = new int[5];

        WhatIspressed whatIspressed = WhatIspressed.none;

        bool IsPressed = false;
        bool TimerEnabled = true;

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
            int rn = rnd.Next(8, 10); // Losowanie poszczególnych elementów

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
                        Field field1 = _listOfField.Where(w => w.X == 1 && w.Y == 3).FirstOrDefault();
                        field1.Type = TypeOfField.redField;
                        field1.Active = true;
                        Field field2 = _listOfField.Where(w => w.X == 0 && w.Y == 3).FirstOrDefault();
                        field2.Type = TypeOfField.redField;
                        field2.Active = true;
                        Field field3 = _listOfField.Where(w => w.X == 0 && w.Y == 4).FirstOrDefault();
                        field3.Type = TypeOfField.redField;
                        field3.Active = true;
                        Field field4 = _listOfField.Where(w => w.X == 0 && w.Y == 5).FirstOrDefault();
                        field4.Type = TypeOfField.redField;
                        field4.Active = true;

                        _oneBlockToMove.Add(field1);
                        _oneBlockToMove.Add(field2);
                        _oneBlockToMove.Add(field3);
                        _oneBlockToMove.Add(field4);

                        CurrentBlockNumber = 4;

                        break;
                    }
                case 5:
                    {
                        Field field1 = _listOfField.Where(w => w.X == 1 && w.Y == 5).FirstOrDefault();
                        field1.Type = TypeOfField.yellowField;
                        field1.Active = true;
                        Field field2 = _listOfField.Where(w => w.X == 0 && w.Y == 4).FirstOrDefault();
                        field2.Type = TypeOfField.yellowField;
                        field2.Active = true;
                        Field field3 = _listOfField.Where(w => w.X == 0 && w.Y == 5).FirstOrDefault();
                        field3.Type = TypeOfField.yellowField;
                        field3.Active = true;
                        Field field4 = _listOfField.Where(w => w.X == 0 && w.Y == 6).FirstOrDefault();
                        field4.Type = TypeOfField.yellowField;
                        field4.Active = true;


                        _oneBlockToMove.Add(field1);
                        _oneBlockToMove.Add(field2);
                        _oneBlockToMove.Add(field3);
                        _oneBlockToMove.Add(field4);

                        CurrentBlockNumber = 5;

                        break;
                    }
                case 6: // Figura 1 obrócona o 90 stopni ( pionowo ) // Zakończone
                    {
                        Field field1 = _listOfField.Where(w => w.X == 0 && w.Y == 3).FirstOrDefault();
                        field1.Type = TypeOfField.blueField;
                        field1.Active = true;
                        Field field2 = _listOfField.Where(w => w.X == 1 && w.Y == 3).FirstOrDefault();
                        field2.Type = TypeOfField.blueField;
                        field2.Active = true;
                        Field field3 = _listOfField.Where(w => w.X == 2 && w.Y == 3).FirstOrDefault();
                        field3.Type = TypeOfField.blueField;
                        field3.Active = true;
                        Field field4 = _listOfField.Where(w => w.X == 3 && w.Y == 3).FirstOrDefault();
                        field4.Type = TypeOfField.blueField;
                        field4.Active = true;


                        _oneBlockToMove.Add(field1);
                        _oneBlockToMove.Add(field2);
                        _oneBlockToMove.Add(field3);
                        _oneBlockToMove.Add(field4);

                        CurrentBlockNumber = 6;

                        break;
                    }
                case 7: // Figura 3 w lustrzanym odbiciu
                    {
                        Field field1 = _listOfField.Where(w => w.X == 1 && w.Y == 4).FirstOrDefault();
                        field1.Type = TypeOfField.orangeField;
                        field1.Active = true;
                        Field field2 = _listOfField.Where(w => w.X == 1 && w.Y == 5).FirstOrDefault();
                        field2.Type = TypeOfField.orangeField;
                        field2.Active = true;
                        Field field3 = _listOfField.Where(w => w.X == 0 && w.Y == 3).FirstOrDefault();
                        field3.Type = TypeOfField.orangeField;
                        field3.Active = true;
                        Field field4 = _listOfField.Where(w => w.X == 0 && w.Y == 4).FirstOrDefault();
                        field4.Type = TypeOfField.orangeField;
                        field4.Active = true;

                        _oneBlockToMove.Add(field1);
                        _oneBlockToMove.Add(field2);
                        _oneBlockToMove.Add(field3);
                        _oneBlockToMove.Add(field4);

                        CurrentBlockNumber = 7;

                        break;
                    }
                case 8: // Figura 7 obrócona o 90 stopni w prawo
                    {
                        Field field1 = _listOfField.Where(w => w.X == 2 && w.Y == 4).FirstOrDefault();
                        field1.Type = TypeOfField.orangeField;
                        field1.Active = true;
                        Field field2 = _listOfField.Where(w => w.X == 1 && w.Y == 4).FirstOrDefault();
                        field2.Type = TypeOfField.orangeField;
                        field2.Active = true;
                        Field field3 = _listOfField.Where(w => w.X == 1 && w.Y == 5).FirstOrDefault();
                        field3.Type = TypeOfField.orangeField;
                        field3.Active = true;
                        Field field4 = _listOfField.Where(w => w.X == 0 && w.Y == 5).FirstOrDefault();
                        field4.Type = TypeOfField.orangeField;
                        field4.Active = true;

                        _oneBlockToMove.Add(field1);
                        _oneBlockToMove.Add(field2);
                        _oneBlockToMove.Add(field3);
                        _oneBlockToMove.Add(field4);

                        CurrentBlockNumber = 8;

                        break;
                    }
                case 9: // Lustrzane odbicie figury 8
                    {
                        Field field1 = _listOfField.Where(w => w.X == 2 && w.Y == 5).FirstOrDefault();
                        field1.Type = TypeOfField.orangeField;
                        field1.Active = true;
                        Field field2 = _listOfField.Where(w => w.X == 1 && w.Y == 5).FirstOrDefault();
                        field2.Type = TypeOfField.orangeField;
                        field2.Active = true;
                        Field field3 = _listOfField.Where(w => w.X == 1 && w.Y == 4).FirstOrDefault();
                        field3.Type = TypeOfField.orangeField;
                        field3.Active = true;
                        Field field4 = _listOfField.Where(w => w.X == 0 && w.Y == 4).FirstOrDefault();
                        field4.Type = TypeOfField.orangeField;
                        field4.Active = true;

                        _oneBlockToMove.Add(field1);
                        _oneBlockToMove.Add(field2);
                        _oneBlockToMove.Add(field3);
                        _oneBlockToMove.Add(field4);

                        CurrentBlockNumber = 9;

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

        public bool Timer_tick()
        {
            if (TimerEnabled != true)
            {
                return false;
            }

            if (IsPressed == true)
            {
                if (CheckingColisionHorizontal(whatIspressed) == true)
                {
                    this.MoveHorizontal(whatIspressed);
                }
            }

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
            else if (CheckingColision(4) == true && CurrentBlockNumber == 4)
            {
                for (int i = 0; i < 4; i++)
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
                        item.Type = TypeOfField.redField;
                    }
                    _oneBlockToMove.RemoveAt(i);
                    var field = new Field(TempX + 1, TempY);
                    field.Type = TypeOfField.redField;
                    _oneBlockToMove.Insert(i, field);
                }
            }
            else if (CheckingColision(5) == true && CurrentBlockNumber == 5)
            {
                for (int i = 0; i < 4; i++)
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
                        item.Type = TypeOfField.yellowField;
                    }
                    _oneBlockToMove.RemoveAt(i);
                    var field = new Field(TempX + 1, TempY);
                    field.Type = TypeOfField.yellowField;
                    _oneBlockToMove.Insert(i, field);
                }
            }
            else if (CheckingColision(6) == true && CurrentBlockNumber == 6)
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
                        item.Type = TypeOfField.blueField;
                    }
                    _oneBlockToMove.RemoveAt(i);
                    var field = new Field(TempX + 1, TempY);
                    field.Type = TypeOfField.blueField;
                    _oneBlockToMove.Insert(i, field);
                }
            }
            else if (CheckingColision(7) == true && CurrentBlockNumber == 7)
            {
                for (int i = 0; i < 4; i++)
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
            else if (CheckingColision(8) == true && CurrentBlockNumber == 8)
            {
                for (int i = 0; i < 4; i++)
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
            else if (CheckingColision(9) == true && CurrentBlockNumber == 9)
            {
                for (int i = 0; i < 4; i++)
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
                    Field query = _listOfField.Where(w => w.X == item.X && w.Y == item.Y).FirstOrDefault();
                    query.Active = false;
                }

                ClearNotActivedRows();
                _oneBlockToMove.Clear();
                CurrentBlockNumber = 0;

                IEnumerable<Field> query2 = _listOfField.Where(w => (w.X == 3 && w.Y == 3) || (w.X == 3 && w.Y == 4) || (w.X == 3 && w.Y == 5) || (w.X == 3 && w.Y == 6));

                int temp = 0;

                foreach (var item in query2)
                {
                    if (item.Type == TypeOfField.none)
                    {
                        temp++;
                    }
                }

                if (temp == 4)
                {
                    GeneratingBlock();
                }
                else
                {
                    TimerEnabled = false;

                    DialogResult result1 = MessageBox.Show("Game Over, Twój wynik to " + this.ReturnPointsAmount().ToString());

                    points = 0;
                    AmountOfRows = 0;

                    for (int i = 0; i < 5; i++)
                    {
                        ArrayOfColors[i] = 0;
                    }

                    if (result1 == DialogResult.OK)
                    {
                        foreach (var item in _listOfField)
                        {
                            item.Type = TypeOfField.none;
                            item.Active = true;
                        }
                        _oneBlockToMove.Clear();
                        GeneratingBlock();
                        TimerEnabled = true;
                    }
                }

            }


            return true;
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
            else if (n == 3)
            {
                int temp = 0;

                (TempX, TempY) = GetIndex(0);

                if (TempX + 1 >= 20)
                {
                    return false;
                }

                Field query = _listOfField.Where(w => w.X == TempX + 1 && w.Y == TempY).FirstOrDefault();

                if (query.Type == TypeOfField.none)
                {
                    temp++;
                }

                (TempX, TempY) = GetIndex(1);

                query = _listOfField.Where(w => w.X == TempX + 1 && w.Y == TempY).FirstOrDefault();

                if (query.Type == TypeOfField.none)
                {
                    temp++;
                }

                (TempX, TempY) = GetIndex(3);

                query = _listOfField.Where(w => w.X == TempX + 1 && w.Y == TempY).FirstOrDefault();

                if (query == null)
                {
                    return false;
                }

                if (query.Type == TypeOfField.none)
                {
                    temp++;
                }


                if (temp == 3)
                {
                    return true;
                }
            }
            else if (n == 4)
            {
                int temp = 0;

                for (int i = 0; i < 4; i++)
                {
                    if (i == 1)
                    {
                        continue;
                    }

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

                if (temp == 3)
                {
                    return true;
                }

            }
            else if (n == 5)
            {
                int temp = 0;

                for (int i = 0; i < 4; i++)
                {
                    if (i == 2)
                    {
                        continue;
                    }

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

                if (temp == 3)
                {
                    return true;
                }

            }
            else if (n == 6)
            {
                Field field = _listOfField.Where(w => w.Y == _oneBlockToMove[3].Y && w.X == _oneBlockToMove[3].X + 1).FirstOrDefault();

                if (field == null)
                {
                    return false;
                }

                if (field.Type == TypeOfField.none && field.Y < 19)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (n == 7)
            {
                int temp = 0;

                for (int i = 0; i < 3; i++)
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

                if (temp == 3)
                {
                    return true;
                }
            }
            else if (n == 8 || n == 9)
            {
                int temp = 0;

                for (int i = 0; i < 4; i++)
                {
                    if (i == 1 || i == 3)
                    {
                        continue;
                    }

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
        } // end


        public bool CheckingColisionHorizontal(WhatIspressed temp) // true możliwy ruch, false ruch niemożliwy
        {
            int TempX;
            int TempY;

            if (temp == WhatIspressed.left)
            {
                if (CurrentBlockNumber == 1)
                {
                    (TempX, TempY) = GetIndex(0);
                    Field query = _listOfField.Where(w => w.X == TempX && w.Y == TempY - 1).FirstOrDefault();

                    if (query == null)
                    {
                        return false;
                    }

                    if (query.Y >= 0 && query.Type == TypeOfField.none)
                    {
                        return true;
                    }
                }
                else if (CurrentBlockNumber == 2 || CurrentBlockNumber == 3)
                {
                    int temp2 = 0;

                    (TempX, TempY) = GetIndex(0);
                    Field query = _listOfField.Where(w => w.X == TempX && w.Y == TempY - 1).FirstOrDefault();

                    if (query == null)
                    {
                        return false;
                    }

                    if (query.Y >= 0 && query.Type == TypeOfField.none)
                    {
                        temp2++;
                    }

                    (TempX, TempY) = GetIndex(2);
                    Field query2 = _listOfField.Where(w => w.X == TempX && w.Y == TempY - 1).FirstOrDefault();

                    if (query2 == null)
                    {
                        return false;
                    }

                    if (query2.Y >= 0 && query2.Type == TypeOfField.none)
                    {
                        temp2++;
                    }

                    if (temp2 == 2)
                    {
                        return true;
                    }
                }
                else if (CurrentBlockNumber == 4)
                {
                    int temp2 = 0;

                    (TempX, TempY) = GetIndex(0);
                    Field query = _listOfField.Where(w => w.X == TempX && w.Y == TempY - 1).FirstOrDefault();

                    if (query == null)
                    {
                        return false;
                    }

                    if (query.Y >= 0 && query.Type == TypeOfField.none)
                    {
                        temp2++;
                    }

                    (TempX, TempY) = GetIndex(1);
                    Field query2 = _listOfField.Where(w => w.X == TempX && w.Y == TempY - 1).FirstOrDefault();

                    if (query2 == null)
                    {
                        return false;
                    }

                    if (query2.Y >= 0 && query2.Type == TypeOfField.none)
                    {
                        temp2++;
                    }

                    if (temp2 == 2)
                    {
                        return true;
                    }
                }
                else if (CurrentBlockNumber == 5)
                {
                    int temp2 = 0;

                    (TempX, TempY) = GetIndex(0);
                    Field query = _listOfField.Where(w => w.X == TempX && w.Y == TempY - 1).FirstOrDefault();

                    if (query == null)
                    {
                        return false;
                    }

                    if (query.Y >= 0 && query.Type == TypeOfField.none)
                    {
                        temp2++;
                    }

                    (TempX, TempY) = GetIndex(1);
                    Field query2 = _listOfField.Where(w => w.X == TempX && w.Y == TempY - 1).FirstOrDefault();

                    if (query2 == null)
                    {
                        return false;
                    }

                    if (query2.Y >= 0 && query2.Type == TypeOfField.none)
                    {
                        temp2++;
                    }

                    if (temp2 == 2)
                    {
                        return true;
                    }
                }
                else if (CurrentBlockNumber == 6)
                {
                    int temp2 = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        (TempX, TempY) = GetIndex(i);
                        Field query2 = _listOfField.Where(w => w.X == TempX && w.Y == TempY - 1).FirstOrDefault();

                        if (query2 == null)
                        {
                            return false;
                        }

                        if (query2.Y >= 0 && query2.Type == TypeOfField.none)
                        {
                            temp2++;
                        }
                    }

                    if (temp2 == 4)
                    {
                        return true;
                    }

                }
                else if (CurrentBlockNumber == 7)
                {
                    int temp2 = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        if (i == 1 || i == 3)
                        {
                            continue;
                        }

                        (TempX, TempY) = GetIndex(i);
                        Field query2 = _listOfField.Where(w => w.X == TempX && w.Y == TempY - 1).FirstOrDefault();

                        if (query2 == null)
                        {
                            return false;
                        }

                        if (query2.Y >= 0 && query2.Type == TypeOfField.none)
                        {
                            temp2++;
                        }
                    }

                    if (temp2 == 2)
                    {
                        return true;
                    }
                }
                else if (CurrentBlockNumber == 8)
                {
                    int temp2 = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        if (i == 2)
                        {
                            continue;
                        }

                        (TempX, TempY) = GetIndex(i);
                        Field query2 = _listOfField.Where(w => w.X == TempX && w.Y == TempY - 1).FirstOrDefault();

                        if (query2 == null)
                        {
                            return false;
                        }

                        if (query2.Y >= 0 && query2.Type == TypeOfField.none)
                        {
                            temp2++;
                        }

                    }

                    if (temp2 == 3)
                    {
                        return true;
                    }
                }
                else if (CurrentBlockNumber == 9)
                {
                    int temp2 = 0;

                    for (int i = 3; i > -1; i--)
                    {
                        if (i == 1)
                        {
                            continue;
                        }

                        (TempX, TempY) = GetIndex(i);
                        Field query2 = _listOfField.Where(w => w.X == TempX && w.Y == TempY - 1).FirstOrDefault();

                        if (query2 == null)
                        {
                            return false;
                        }

                        if (query2.Y >= 0 && query2.Type == TypeOfField.none)
                        {
                            temp2++;
                        }
                    }

                    if (temp2 == 3)
                    {
                        return true;
                    }
                }

            }
            else if (temp == WhatIspressed.right)
            {
                if (CurrentBlockNumber == 1)
                {
                    (TempX, TempY) = GetIndex(3);
                    Field query = _listOfField.Where(w => w.X == TempX && w.Y == TempY + 1).FirstOrDefault();

                    if (query == null)
                    {
                        return false;
                    }

                    if (query.Y < 10 && query.Type == TypeOfField.none)
                    {
                        return true;
                    }

                }
                else if (CurrentBlockNumber == 2 || CurrentBlockNumber == 3)
                {
                    int temp2 = 0;

                    for (int i = 1; i < 4; i++)
                    {
                        if (i == 2)
                        {
                            continue;
                        }

                        (TempX, TempY) = GetIndex(i);
                        Field query = _listOfField.Where(w => w.X == TempX && w.Y == TempY + 1).FirstOrDefault();

                        if (query == null)
                        {
                            return false;
                        }

                        if (query.Y < 10 && query.Type == TypeOfField.none)
                        {
                            temp2++;
                        }
                    }

                    if (temp2 == 2)
                    {
                        return true;
                    }
                }
                else if (CurrentBlockNumber == 4)
                {
                    int temp2 = 0;
                    (TempX, TempY) = GetIndex(0);
                    Field query = _listOfField.Where(w => w.X == TempX && w.Y == TempY + 1).FirstOrDefault();

                    if (query == null)
                    {
                        return false;
                    }

                    if (query.Y < 10 && query.Type == TypeOfField.none)
                    {
                        temp2++;
                    }

                    (TempX, TempY) = GetIndex(3);
                    Field query2 = _listOfField.Where(w => w.X == TempX && w.Y == TempY + 1).FirstOrDefault();

                    if (query2 == null)
                    {
                        return false;
                    }

                    if (query2.Y < 10 && query2.Type == TypeOfField.none)
                    {
                        temp2++;
                    }

                    if (temp2 == 2)
                    {
                        return true;
                    }
                }
                else if (CurrentBlockNumber == 5)
                {
                    int temp2 = 0;
                    (TempX, TempY) = GetIndex(0);
                    Field query = _listOfField.Where(w => w.X == TempX && w.Y == TempY + 1).FirstOrDefault();

                    if (query == null)
                    {
                        return false;
                    }

                    if (query.Y < 10 && query.Type == TypeOfField.none)
                    {
                        temp2++;
                    }

                    (TempX, TempY) = GetIndex(3);
                    Field query2 = _listOfField.Where(w => w.X == TempX && w.Y == TempY + 1).FirstOrDefault();

                    if (query2 == null)
                    {
                        return false;
                    }

                    if (query2.Y < 10 && query2.Type == TypeOfField.none)
                    {
                        temp2++;
                    }

                    if (temp2 == 2)
                    {
                        return true;
                    }
                }
                else if (CurrentBlockNumber == 6)
                {
                    int temp2 = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        (TempX, TempY) = GetIndex(i);

                        Field query2 = _listOfField.Where(w => w.X == TempX && w.Y == TempY + 1).FirstOrDefault();

                        if (query2 == null)
                        {
                            return false;
                        }

                        if (query2.Y < 10 && query2.Type == TypeOfField.none)
                        {
                            temp2++;
                        }
                    }

                    if (temp2 == 4)
                    {
                        return true;
                    }
                }
                else if (CurrentBlockNumber == 7)
                {
                    int temp2 = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        if (i == 0 || i == 2)
                        {
                            continue;
                        }

                        (TempX, TempY) = GetIndex(i);

                        Field query2 = _listOfField.Where(w => w.X == TempX && w.Y == TempY + 1).FirstOrDefault();

                        if (query2 == null)
                        {
                            return false;
                        }

                        if (query2.Y < 10 && query2.Type == TypeOfField.none)
                        {
                            temp2++;
                        }
                    }

                    if (temp2 == 2)
                    {
                        return true;
                    }
                }
                else if (CurrentBlockNumber == 8)
                {
                    int temp2 = 0;

                    for (int i = 3; i > -1; i--)
                    {
                        if (i == 1)
                        {
                            continue;
                        }

                        (TempX, TempY) = GetIndex(i);

                        Field query2 = _listOfField.Where(w => w.X == TempX && w.Y == TempY + 1).FirstOrDefault();

                        if (query2 == null)
                        {
                            return false;
                        }

                        if (query2.Y < 10 && query2.Type == TypeOfField.none)
                        {
                            temp2++;
                        }
                    }

                    if (temp2 == 3)
                    {
                        return true;
                    }
                }
                else if (CurrentBlockNumber == 9)
                {
                    int temp2 = 0;

                    for (int i = 3; i > -1; i--)
                    {
                        if (i == 2)
                        {
                            continue;
                        }

                        (TempX, TempY) = GetIndex(i);

                        Field query2 = _listOfField.Where(w => w.X == TempX && w.Y == TempY + 1).FirstOrDefault();

                        if (query2 == null)
                        {
                            return false;
                        }

                        if (query2.Y < 10 && query2.Type == TypeOfField.none)
                        {
                            temp2++;
                        }
                    }

                    if (temp2 == 3)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void MoveHorizontal(WhatIspressed temp)
        {
            if (temp == WhatIspressed.right)
            {
                if (CurrentBlockNumber == 1)
                {
                    for (int i = 3; i >= 0; i--)
                    {
                        int TempX;
                        int TempY;

                        (TempX, TempY) = GetIndex(i);

                        IEnumerable<Field> PrevQuery = _listOfField.Where(w => w.X == TempX && w.Y == TempY);

                        foreach (var item in PrevQuery)
                        {
                            item.Type = TypeOfField.none;
                        }

                        IEnumerable<Field> query = _listOfField.Where(w => w.X == TempX && w.Y == TempY + 1);

                        foreach (var item in query)
                        {
                            item.Type = TypeOfField.blueField;
                        }
                        _oneBlockToMove.RemoveAt(i);
                        var field = new Field(TempX, TempY + 1);
                        field.Type = TypeOfField.blueField;
                        _oneBlockToMove.Insert(i, field);
                    }
                }
                else if (CurrentBlockNumber == 2 || CurrentBlockNumber == 3)
                {
                    for (int i = 1; i < 4; i++)
                    {
                        if (i == 2)
                        {
                            continue;
                        }

                        int TempX;
                        int TempY;

                        (TempX, TempY) = GetIndex(i);

                        IEnumerable<Field> PrevQuery = _listOfField.Where(w => w.X == TempX && w.Y == TempY);

                        foreach (var item in PrevQuery)
                        {
                            item.Type = TypeOfField.none;
                        }


                        IEnumerable<Field> query = _listOfField.Where(w => w.X == TempX && w.Y == TempY + 1);

                        foreach (var item in query)
                        {
                            if (CurrentBlockNumber == 2)
                                item.Type = TypeOfField.greenField;
                            else if (CurrentBlockNumber == 3)
                                item.Type = TypeOfField.orangeField;
                        }
                        _oneBlockToMove.RemoveAt(i);
                        var field = new Field(TempX, TempY + 1);
                        if (CurrentBlockNumber == 2)
                            field.Type = TypeOfField.greenField;
                        else if (CurrentBlockNumber == 3)
                            field.Type = TypeOfField.orangeField;
                        _oneBlockToMove.Insert(i, field);
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        if (i == 1)
                        {
                            continue;
                        }

                        int TempX;
                        int TempY;

                        (TempX, TempY) = GetIndex(i);

                        IEnumerable<Field> PrevQuery = _listOfField.Where(w => w.X == TempX && w.Y == TempY);

                        foreach (var item in PrevQuery)
                        {
                            item.Type = TypeOfField.none;
                        }

                        IEnumerable<Field> query = _listOfField.Where(w => w.X == TempX && w.Y == TempY + 1);

                        foreach (var item in query)
                        {
                            if (CurrentBlockNumber == 2)
                                item.Type = TypeOfField.greenField;
                            else if (CurrentBlockNumber == 3)
                                item.Type = TypeOfField.orangeField;
                        }
                        _oneBlockToMove.RemoveAt(i);
                        var field = new Field(TempX, TempY + 1);
                        if (CurrentBlockNumber == 2)
                            field.Type = TypeOfField.greenField;
                        else if (CurrentBlockNumber == 3)
                            field.Type = TypeOfField.orangeField;
                        _oneBlockToMove.Insert(i, field);
                    }
                }
                else if (CurrentBlockNumber == 4 || CurrentBlockNumber == 5)
                {
                    int TempX;
                    int TempY;

                    (TempX, TempY) = GetIndex(0);
                    IEnumerable<Field> PrevQuery = _listOfField.Where(w => w.X == TempX && w.Y == TempY);

                    foreach (var item in PrevQuery)
                    {
                        item.Type = TypeOfField.none;
                    }

                    IEnumerable<Field> query = _listOfField.Where(w => w.X == TempX && w.Y == TempY + 1);

                    foreach (var item in query)
                    {
                        if (CurrentBlockNumber == 4)
                            item.Type = TypeOfField.redField;
                        else if (CurrentBlockNumber == 5)
                            item.Type = TypeOfField.yellowField;
                    }

                    _oneBlockToMove.RemoveAt(0);
                    var field = new Field(TempX, TempY + 1);
                    if (CurrentBlockNumber == 4)
                        field.Type = TypeOfField.redField;
                    else if (CurrentBlockNumber == 5)
                        field.Type = TypeOfField.yellowField;
                    _oneBlockToMove.Insert(0, field);

                    for (int i = 3; i > 0; i--)
                    {
                        int TempX2;
                        int TempY2;

                        (TempX2, TempY2) = GetIndex(i);
                        IEnumerable<Field> PrevQuery2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2);

                        foreach (var item in PrevQuery2)
                        {
                            item.Type = TypeOfField.none;
                        }

                        IEnumerable<Field> query2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2 + 1);

                        foreach (var item in query2)
                        {
                            if (CurrentBlockNumber == 4)
                                item.Type = TypeOfField.redField;
                            else if (CurrentBlockNumber == 5)
                                item.Type = TypeOfField.yellowField;
                        }

                        _oneBlockToMove.RemoveAt(i);
                        var field2 = new Field(TempX2, TempY2 + 1);
                        if (CurrentBlockNumber == 4)
                            field2.Type = TypeOfField.redField;
                        else if (CurrentBlockNumber == 5)
                            field2.Type = TypeOfField.yellowField;
                        _oneBlockToMove.Insert(i, field2);
                    }
                }
                else if (CurrentBlockNumber == 6)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int TempX2;
                        int TempY2;

                        (TempX2, TempY2) = GetIndex(i);
                        IEnumerable<Field> PrevQuery2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2);

                        foreach (var item in PrevQuery2)
                        {
                            item.Type = TypeOfField.none;
                        }

                        IEnumerable<Field> query2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2 + 1);

                        foreach (var item in query2)
                        {
                            item.Type = TypeOfField.blueField;
                        }

                        _oneBlockToMove.RemoveAt(i);
                        var field2 = new Field(TempX2, TempY2 + 1);
                        field2.Type = TypeOfField.blueField;
                        _oneBlockToMove.Insert(i, field2);

                    }
                }
                else if (CurrentBlockNumber == 7)
                {
                    for (int i = 3; i > -1; i--)
                    {
                        int TempX2;
                        int TempY2;

                        (TempX2, TempY2) = GetIndex(i);
                        IEnumerable<Field> PrevQuery2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2);

                        foreach (var item in PrevQuery2)
                        {
                            item.Type = TypeOfField.none;
                        }

                        IEnumerable<Field> query2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2 + 1);

                        foreach (var item in query2)
                        {
                            item.Type = TypeOfField.orangeField;
                        }

                        _oneBlockToMove.RemoveAt(i);
                        var field2 = new Field(TempX2, TempY2 + 1);
                        field2.Type = TypeOfField.orangeField;
                        _oneBlockToMove.Insert(i, field2);
                    }
                }
                else if (CurrentBlockNumber == 8)
                {
                    for (int i = 3; i > -1; i--)
                    {
                        int TempX2;
                        int TempY2;

                        (TempX2, TempY2) = GetIndex(i);
                        IEnumerable<Field> PrevQuery2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2);

                        foreach (var item in PrevQuery2)
                        {
                            item.Type = TypeOfField.none;
                        }

                        IEnumerable<Field> query2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2 + 1);

                        foreach (var item in query2)
                        {
                            item.Type = TypeOfField.orangeField;
                        }

                        _oneBlockToMove.RemoveAt(i);
                        var field2 = new Field(TempX2, TempY2 + 1);
                        field2.Type = TypeOfField.orangeField;
                        _oneBlockToMove.Insert(i, field2);
                    }
                }
                else if (CurrentBlockNumber == 9)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int TempX2;
                        int TempY2;

                        (TempX2, TempY2) = GetIndex(i);
                        IEnumerable<Field> PrevQuery2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2);

                        foreach (var item in PrevQuery2)
                        {
                            item.Type = TypeOfField.none;
                        }

                        IEnumerable<Field> query2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2 + 1);

                        foreach (var item in query2)
                        {
                            item.Type = TypeOfField.orangeField;
                        }

                        _oneBlockToMove.RemoveAt(i);
                        var field2 = new Field(TempX2, TempY2 + 1);
                        field2.Type = TypeOfField.orangeField;
                        _oneBlockToMove.Insert(i, field2);
                    }
                }

            }
            else if (temp == WhatIspressed.left)
            {
                if (CurrentBlockNumber == 1)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int TempX;
                        int TempY;

                        (TempX, TempY) = GetIndex(i);

                        IEnumerable<Field> PrevQuery = _listOfField.Where(w => w.X == TempX && w.Y == TempY);

                        foreach (var item in PrevQuery)
                        {
                            item.Type = TypeOfField.none;
                        }

                        IEnumerable<Field> query = _listOfField.Where(w => w.X == TempX && w.Y == TempY - 1);

                        foreach (var item in query)
                        {
                            item.Type = TypeOfField.blueField;
                        }
                        _oneBlockToMove.RemoveAt(i);
                        var field = new Field(TempX, TempY - 1);
                        field.Type = TypeOfField.blueField;
                        _oneBlockToMove.Insert(i, field);
                    }
                }
                else if (CurrentBlockNumber == 2 || CurrentBlockNumber == 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (i == 1)
                        {
                            continue;
                        }

                        int TempX;
                        int TempY;

                        (TempX, TempY) = GetIndex(i);

                        IEnumerable<Field> PrevQuery = _listOfField.Where(w => w.X == TempX && w.Y == TempY);

                        foreach (var item in PrevQuery)
                        {
                            item.Type = TypeOfField.none;
                        }


                        IEnumerable<Field> query = _listOfField.Where(w => w.X == TempX && w.Y == TempY - 1);

                        foreach (var item in query)
                        {
                            if (CurrentBlockNumber == 2)
                                item.Type = TypeOfField.greenField;
                            else if (CurrentBlockNumber == 3)
                                item.Type = TypeOfField.orangeField;
                        }
                        _oneBlockToMove.RemoveAt(i);
                        var field = new Field(TempX, TempY - 1);
                        if (CurrentBlockNumber == 2)
                            field.Type = TypeOfField.greenField;
                        else if (CurrentBlockNumber == 3)
                            field.Type = TypeOfField.orangeField;
                        _oneBlockToMove.Insert(i, field);
                    }
                    for (int i = 1; i < 4; i++)
                    {
                        if (i == 2)
                        {
                            continue;
                        }

                        int TempX;
                        int TempY;

                        (TempX, TempY) = GetIndex(i);

                        IEnumerable<Field> PrevQuery = _listOfField.Where(w => w.X == TempX && w.Y == TempY);

                        foreach (var item in PrevQuery)
                        {
                            item.Type = TypeOfField.none;
                        }


                        IEnumerable<Field> query = _listOfField.Where(w => w.X == TempX && w.Y == TempY - 1);

                        foreach (var item in query)
                        {
                            if (CurrentBlockNumber == 2)
                                item.Type = TypeOfField.greenField;
                            else if (CurrentBlockNumber == 3)
                                item.Type = TypeOfField.orangeField;
                        }
                        _oneBlockToMove.RemoveAt(i);
                        var field = new Field(TempX, TempY - 1);
                        if (CurrentBlockNumber == 2)
                            field.Type = TypeOfField.greenField;
                        else if (CurrentBlockNumber == 3)
                            field.Type = TypeOfField.orangeField;
                        _oneBlockToMove.Insert(i, field);
                    }
                }
                else if (CurrentBlockNumber == 4 || CurrentBlockNumber == 5)
                {
                    int TempX;
                    int TempY;

                    (TempX, TempY) = GetIndex(0);

                    IEnumerable<Field> PrevQuery = _listOfField.Where(w => w.X == TempX && w.Y == TempY);

                    foreach (var item in PrevQuery)
                    {
                        item.Type = TypeOfField.none;
                    }

                    IEnumerable<Field> query = _listOfField.Where(w => w.X == TempX && w.Y == TempY - 1);

                    foreach (var item in query)
                    {
                        if (CurrentBlockNumber == 4)
                            item.Type = TypeOfField.redField;
                        else if (CurrentBlockNumber == 5)
                            item.Type = TypeOfField.yellowField;
                    }
                    _oneBlockToMove.RemoveAt(0);
                    var field = new Field(TempX, TempY - 1);
                    if (CurrentBlockNumber == 4)
                        field.Type = TypeOfField.redField;
                    else if (CurrentBlockNumber == 5)
                        field.Type = TypeOfField.yellowField;
                    _oneBlockToMove.Insert(0, field);

                    for (int i = 1; i < 4; i++)
                    {
                        int TempX2;
                        int TempY2;

                        (TempX2, TempY2) = GetIndex(i);

                        IEnumerable<Field> PrevQuery2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2);

                        foreach (var item in PrevQuery2)
                        {
                            item.Type = TypeOfField.none;
                        }

                        IEnumerable<Field> query2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2 - 1);

                        foreach (var item in query2)
                        {
                            if (CurrentBlockNumber == 4)
                                item.Type = TypeOfField.redField;
                            else if (CurrentBlockNumber == 5)
                                item.Type = TypeOfField.yellowField;
                        }
                        _oneBlockToMove.RemoveAt(i);
                        var field2 = new Field(TempX2, TempY2 - 1);
                        if (CurrentBlockNumber == 4)
                            field2.Type = TypeOfField.redField;
                        else if (CurrentBlockNumber == 5)
                            field2.Type = TypeOfField.yellowField;
                        _oneBlockToMove.Insert(i, field2);
                    }
                }
                else if (CurrentBlockNumber == 6)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int TempX2;
                        int TempY2;

                        (TempX2, TempY2) = GetIndex(i);

                        IEnumerable<Field> PrevQuery2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2);

                        foreach (var item in PrevQuery2)
                        {
                            item.Type = TypeOfField.none;
                        }

                        IEnumerable<Field> query2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2 - 1);

                        foreach (var item in query2)
                        {
                            item.Type = TypeOfField.blueField;
                        }
                        _oneBlockToMove.RemoveAt(i);
                        var field2 = new Field(TempX2, TempY2 - 1);
                        field2.Type = TypeOfField.blueField;
                        _oneBlockToMove.Insert(i, field2);
                    }
                }
                else if (CurrentBlockNumber == 7)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int TempX2;
                        int TempY2;

                        (TempX2, TempY2) = GetIndex(i);

                        IEnumerable<Field> PrevQuery2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2);

                        foreach (var item in PrevQuery2)
                        {
                            item.Type = TypeOfField.none;
                        }

                        IEnumerable<Field> query2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2 - 1);

                        foreach (var item in query2)
                        {
                            item.Type = TypeOfField.orangeField;
                        }
                        _oneBlockToMove.RemoveAt(i);
                        var field2 = new Field(TempX2, TempY2 - 1);
                        field2.Type = TypeOfField.orangeField;
                        _oneBlockToMove.Insert(i, field2);
                    }
                }
                else if (CurrentBlockNumber == 8)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int TempX2;
                        int TempY2;

                        (TempX2, TempY2) = GetIndex(i);

                        IEnumerable<Field> PrevQuery2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2);

                        foreach (var item in PrevQuery2)
                        {
                            item.Type = TypeOfField.none;
                        }

                        IEnumerable<Field> query2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2 - 1);

                        foreach (var item in query2)
                        {
                            item.Type = TypeOfField.orangeField;
                        }
                        _oneBlockToMove.RemoveAt(i);
                        var field2 = new Field(TempX2, TempY2 - 1);
                        field2.Type = TypeOfField.orangeField;
                        _oneBlockToMove.Insert(i, field2);
                    }
                }
                else if (CurrentBlockNumber == 9)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int TempX2;
                        int TempY2;

                        (TempX2, TempY2) = GetIndex(i);

                        IEnumerable<Field> PrevQuery2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2);

                        foreach (var item in PrevQuery2)
                        {
                            item.Type = TypeOfField.none;
                        }

                        IEnumerable<Field> query2 = _listOfField.Where(w => w.X == TempX2 && w.Y == TempY2 - 1);

                        foreach (var item in query2)
                        {
                            item.Type = TypeOfField.orangeField;
                        }
                        _oneBlockToMove.RemoveAt(i);
                        var field2 = new Field(TempX2, TempY2 - 1);
                        field2.Type = TypeOfField.orangeField;
                        _oneBlockToMove.Insert(i, field2);
                    }
                }
            }

            this.Unpressing();
        }

        public void Pressing(Keys keys)
        {
            IsPressed = true;

            if (keys == Keys.Left)
            {
                whatIspressed = WhatIspressed.left;
            }
            else if (keys == Keys.Right)
            {
                whatIspressed = WhatIspressed.right;
            }
        }

        public void Unpressing()
        {
            IsPressed = false;
            whatIspressed = WhatIspressed.none;
        }

        public void ClearNotActivedRows()
        {
            int Test()
            {
                for (int i = 19; i > 0; i--)
                {
                    IEnumerable<Field> query = _listOfField.Where(w => w.X == i);

                    int temp = 0;

                    foreach (var item in query)
                    {
                        if (item.Active == false && item.Type != TypeOfField.none)
                        {
                            temp++;
                        }
                    }

                    if (temp == 10)
                    {
                        return i;
                    }
                }

                return -1;
            }

            int tempIntiger = Test();

            if (tempIntiger != -1)
            {

                for (int i = tempIntiger; i > 0; i--)
                {
                    IEnumerable<Field> FirstList = _listOfField.Where(w => w.X == i);
                    IEnumerable<Field> SecoundList = _listOfField.Where(w => w.X == i - 1);

                    int temp = 0;
                    foreach (var item in FirstList)
                    {
                        if (item.Type == TypeOfField.blueField)
                        {
                            points += 50;
                            ArrayOfColors[4]++;
                        }
                        else if (item.Type == TypeOfField.greenField)
                        {
                            points += 75;
                            ArrayOfColors[1]++;
                        }
                        else if (item.Type == TypeOfField.redField)
                        {
                            points += 100;
                            ArrayOfColors[0]++;
                        }
                        else if (item.Type == TypeOfField.yellowField)
                        {
                            points += 150;
                            ArrayOfColors[2]++;
                        }
                        else if (item.Type == TypeOfField.orangeField)
                        {
                            points += 200;
                            ArrayOfColors[3]++;
                        }

                        Field query = SecoundList.Where(w => w.Y == temp).FirstOrDefault();
                        item.Type = query.Type;
                        item.Active = query.Active;
                        temp++;
                    }
                }
                AmountOfRows++;
            }
        }

        public int ReturnPointsAmount()
        {
            return points;
        }

        public int ReturnRowsAmount()
        {
            return AmountOfRows;
        }

        public void AddPointsByTime()
        {
            points += 10;
        }

        public int ReturnAmountOfColors(int n)
        {
            return ArrayOfColors[n];
        }
    }
}
