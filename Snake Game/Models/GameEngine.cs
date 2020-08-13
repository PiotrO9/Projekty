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

        public GameEngine()
        {
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    var field = new Field(i, j);
                    listOfFields.Add(field);
                }
            }
        }

        public void PrintStartingPosition()
        {
            IEnumerable<PictureBox> Pictures = listOfFields.Select(s => s.PictureField).Where(w => w.Name == "Picture55" || w.Name == "Picture56");
            IEnumerable<Field> Fields = listOfFields.Where(w => w.X == 5 &&);

            foreach (var item in Pictures)
            {
                item.BackColor = Color.FromArgb(255, 0, 0);
            }
        }

    }
}
