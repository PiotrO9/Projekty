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

        public void SettingStartFields()
        {
            IEnumerable<Field> Fields = listOfFields.Where(w => (w.X == 5 && w.Y == 5) || (w.X == 5 && w.Y == 6) || (w.X == 5 && w.Y == 7));

            foreach (var item in Fields)
            {
                item.Type = TypeOfField.Snake;
            }
        }

        public void PrintingElements()
        {
            foreach (var item in listOfFields)
            {
                if (item.Type == TypeOfField.None)
                {
                    item.PictureField.BackColor = Color.FromArgb(255, 0, 0);
                }
                else if (item.Type == TypeOfField.Snake)
                {
                    item.PictureField.BackColor = Color.FromArgb(0, 191, 255);
                }
                else if (item.Type == TypeOfField.Snake)
                {
                    item.PictureField.BackColor = Color.FromArgb(0, 255, 0);
                }
            }
        }

        //public void PrintStartingPosition()
        //{
        //    IEnumerable<PictureBox> Pictures = listOfFields.Select(s => s.PictureField).Where(w => w.Name == "Picture55" || w.Name == "Picture56");
        //    IEnumerable<Field> Fields = listOfFields.Where(w => w.X == 5 &&);

        //    foreach (var item in Pictures)
        //    {
        //        item.BackColor = Color.FromArgb(255, 0, 0);
        //    }
        //}

    }
}
