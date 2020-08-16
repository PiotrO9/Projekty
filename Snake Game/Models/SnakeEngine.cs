using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
