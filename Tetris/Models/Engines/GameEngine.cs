﻿using System;
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
        WhatIspressed whatIspressed = WhatIspressed.none;

        bool IsPressed = false;




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
            int rn = rnd.Next(1, 2);

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
    }
}