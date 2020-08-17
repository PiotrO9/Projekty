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

        private SnakeEngine _generatingSnake = new SnakeEngine();

        public GameEngine()
        {
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

        public void UserChangeDIrectionRequest(Direction direction)
        {

        }

        public void SnakeMove(Direction direction)
        {

        }

        public void SettingStartFields()
        {
            IEnumerable<Field> Fields = listOfFields.Where(w => (w.X == 5 && w.Y == 5) || (w.X == 5 && w.Y == 6) || (w.X == 5 && w.Y == 7));

            foreach (var item in Fields)
            {
                item.Type = TypeOfField.Snake;
            }
        }

    }
}
