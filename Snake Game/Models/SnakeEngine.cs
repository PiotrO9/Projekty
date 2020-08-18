using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game.Models
{
    class SnakeEngine
    {
        private List<Field> listOfSnakeElements = new List<Field>();
        private readonly List<Field> _listOfFields;

        public SnakeEngine(List<Field> listOfFields)
        {
            this._listOfFields = listOfFields ??
                throw new ArgumentNullException($"{nameof(listOfFields)} can't be null");

            for (int i = 5; i < 9; i++)
            {
                var field = new Field(5, i);
                field.Type = TypeOfField.Snake;
                listOfSnakeElements.Add(field);
            }
        }

        public bool CheckIfMovePossible(Direction direction)
        {
            (int x, int y) = GetIndex(direction);

            return CheckIfPossibleMove(x, y);
        }

        public (int, int) GetIndex(Direction direction)
        {
            int TempX = 0;
            int TempY = 0;

            if (direction == Direction.left)
            {
                TempX = listOfSnakeElements[0].X;
                TempY = listOfSnakeElements[0].Y - 1;
            }
            else if (direction == Direction.right)
            {
                TempX = listOfSnakeElements[0].X;
                TempY = listOfSnakeElements[0].Y + 1;
            }
            else if (direction == Direction.up)
            {
                TempX = listOfSnakeElements[0].X - 1;
                TempY = listOfSnakeElements[0].Y;
            }
            else if (direction == Direction.down)
            {
                TempX = listOfSnakeElements[0].X + 1;
                TempY = listOfSnakeElements[0].Y;
            }

            return (TempX, TempY);
        }

        public bool CheckIfPossibleMove(int x, int y)
            => this._listOfFields.Any(a => a.X == x && a.Y == y && a.Type != TypeOfField.Snake);


        public void SnakeMove(Direction dir)
        {
            (int x, int y) = GetIndex(dir);

            int temp = listOfSnakeElements.Count - 1;

            IEnumerable<Field> query = _listOfFields.Where(w => w.X == x && w.Y == y);
            IEnumerable<Field> last = _listOfFields.Where(w => w.X == listOfSnakeElements[temp].X && w.Y == listOfSnakeElements[temp].Y);
            foreach (var item in query)
            {
                item.Type = TypeOfField.Snake;
                listOfSnakeElements.Insert(0, item);
                listOfSnakeElements.RemoveAt(listOfSnakeElements.Count - 1);


                foreach (var element in last)
                {
                    element.Type = TypeOfField.None;
                }
            }

        }

        public void SnakeAdd(Direction direction)
        {
            (int x, int y) = GetIndex(direction);
            IEnumerable<Field> query = _listOfFields.Where(w => w.X == x && w.Y == y);
            foreach (var item in query)
            {
                listOfSnakeElements.Insert(0, item);
            }

        }

        public void RandomFoodGenerating()
        {
            bool temp = false;

            int rn1;
            int rn2;
            IEnumerable<Field> query;

            Random rnd = new Random();
            do
            {
                rn1 = rnd.Next(0, 30);
                rn2 = rnd.Next(0, 30);

                query = _listOfFields.Where(w => w.X == rn1 && w.Y == rn2);

                foreach (var item in query)
                {
                    if (item.Type == TypeOfField.None)
                    {
                        temp = true;
                    }
                }
            }
            while (temp == false);

            foreach (var item in query)
            {
                item.Type = TypeOfField.Food;
            }
        }
    }
}
