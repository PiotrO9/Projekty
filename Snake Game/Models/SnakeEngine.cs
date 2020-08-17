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

        public SnakeEngine()
        {
            for (int i = 5; i < 8; i++)
            {
                var field = new Field(5, i);
                field.Type = TypeOfField.Snake;
                listOfSnakeElements.Add(field);
            }
        }

        public void PrintingElementsSnakeEngine()
        {
            foreach (var item in listOfSnakeElements)
            {
                item.PictureField.BackColor = Color.FromArgb(0, 191, 255);
            }
        }

        public void SnakeMove(Direction dir)
        {
            if (dir == Direction.left)
            {
                var field = new Field(listOfSnakeElements[0].X, listOfSnakeElements[0].Y - 1);
                field.Type = TypeOfField.Snake;
                listOfSnakeElements.Insert(0, field);
                listOfSnakeElements.RemoveAt(listOfSnakeElements.Count - 1);
            }
        }

        public void SnakeAteFood()
        {

        }

        public void ChangeDirection(Direction direction)
        {

        }
    }
}
