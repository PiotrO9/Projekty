using System;
using System.Collections.Generic;
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
    }
}
