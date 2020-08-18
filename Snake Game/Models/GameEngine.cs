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

        public Direction nexDir = Direction.left;
        private Direction snakeDir { get; set; }

        private readonly SnakeEngine _snakeEngine;

        public GameEngine()
        {
            this._snakeEngine = new SnakeEngine(listOfFields);
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
                if (snakeDir == Direction.down)
                {
                    return;
                }
                else
                {
                    nexDir = Direction.up;
                }
            }
            else if (keys == Keys.Down)
            {
                if (snakeDir == Direction.up)
                {
                    return;
                }
                else
                {
                    nexDir = Direction.down;
                }
            }
            else if (keys == Keys.Right)
            {
                if (snakeDir == Direction.left)
                {
                    return;
                }
                else
                {
                    nexDir = Direction.right;
                }
            }
            else if (keys == Keys.Left)
            {
                if (snakeDir == Direction.right)
                {
                    return;
                }
                else
                {
                    nexDir = Direction.left;
                }
            }
        }

        public bool TimerTick()
        {
            if (_snakeEngine.CheckIfMovePossible(nexDir) == true)
            {
                _snakeEngine.SnakeMove(nexDir);
                snakeDir = nexDir;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void SettingStartFields()
        {
            nexDir = Direction.up;
            listOfFields.ForEach(f => f.Type = TypeOfField.None);

            IEnumerable<Field> fields = listOfFields.Where(w => (w.X == 15 && w.Y == 15) ||
                                                                (w.X == 15 && w.Y == 16) ||
                                                                (w.X == 15 && w.Y == 17)).
                                                    OrderBy(o => o.Y);

            foreach (var item in fields)
            {
                item.Type = TypeOfField.Snake;
            }
            this._snakeEngine.NewSnake(fields);
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
            (int x, int y) = _snakeEngine.GetIndex(nexDir);
            IEnumerable<Field> query = listOfFields.Where(w => w.X == x && w.Y == y);
            foreach (var item in query)
            {
                if (item.Type == TypeOfField.Food)
                {
                    item.Type = TypeOfField.Snake;
                    _snakeEngine.SnakeAdd(nexDir);
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
