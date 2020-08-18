using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game.Models
{
    class GameEngine
    {
        private List<Field> listOfFields = new List<Field>();

        public IEnumerable<PictureBox> Pictures => listOfFields.Select(s => s.PictureField);

        public Direction dir = Direction.left;

        private SnakeEngine _generatingSnake;

        public GameEngine()
        {
            this._generatingSnake = new SnakeEngine(listOfFields);
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    var field = new Field(i, j);
                    field.Type = TypeOfField.None;
                    listOfFields.Add(field);
                }
            }
        }

        public void UserChangeDirectionRequest(Keys keys)
        {
            if (keys == Keys.Up)
            {
                if (dir == Direction.down)
                {
                    return;
                }
                else
                {
                    dir = Direction.up;
                }
            }
            else if (keys == Keys.Down)
            {
                if (dir == Direction.up)
                {
                    return;
                }
                else
                {
                    dir = Direction.down;
                }
            }
            else if (keys == Keys.Right)
            {
                if (dir == Direction.left)
                {
                    return;
                }
                else
                {
                    dir = Direction.right;
                }
            }
            else if (keys == Keys.Left)
            {
                if (dir == Direction.right)
                {
                    return;
                }
                else
                {
                    dir = Direction.left;
                }
            }
        }

        public int TimerTick()
        {
            if (_generatingSnake.CheckIfMovePossible(dir) == true)
            {
                _generatingSnake.SnakeMove(dir);
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void SettingStartFields()
        {
            foreach (var item in listOfFields)
            {
                item.Type = TypeOfField.None;
            }

            IEnumerable<Field> Fields = listOfFields.Where(w => (w.X == 5 && w.Y == 5) || (w.X == 5 && w.Y == 6) || (w.X == 5 && w.Y == 7));

            foreach (var item in Fields)
            {
                item.Type = TypeOfField.Snake;
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

                query = listOfFields.Where(w => w.X == rn1 && w.Y == rn2);

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

        public void IfSnakeAteFood()
        {
            (int x, int y) = _generatingSnake.GetIndex(dir);
            IEnumerable<Field> query = listOfFields.Where(w => w.X == x && w.Y == y);
            foreach (var item in query)
            {
                if (item.Type == TypeOfField.Food)
                {
                    item.Type = TypeOfField.Snake;
                    _generatingSnake.SnakeAdd(dir);
                    RandomFoodGenerating();
                }
            }
        }
        public void GameOver()
        {
            MessageBox.Show("Game Over, twój wynik to: " + listOfFields.Where(w => w.Type == TypeOfField.Snake).Count());
            SettingStartFields();
            RandomFoodGenerating();
        }
    }
}
