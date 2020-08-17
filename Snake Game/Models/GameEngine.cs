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

        public void TimerTick()
        {
            if (_generatingSnake.CheckIfMovePossible(dir) == true)
            {
                _generatingSnake.SnakeMove(dir);
            }
        }

        public void SettingStartFields()
        {
            IEnumerable<Field> Fields = listOfFields.Where(w => (w.X == 5 && w.Y == 5) || (w.X == 5 && w.Y == 6) || (w.X == 5 && w.Y == 7));

            foreach (var item in Fields)
            {
                item.Type = TypeOfField.Snake;
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
                    item.Type = TypeOfField.None;
                    _generatingSnake.SnakeAdd(dir);

                }
            }
        }


    }
}
