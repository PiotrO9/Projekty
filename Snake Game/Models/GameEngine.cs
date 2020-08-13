using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game.Models
{
    class GameEngine
    {
        public readonly List<Field> listOfFields = new List<Field>();

        public IEnumerable<Panel> Panels => listOfFields.Select(s => s.PanelField);

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
    }
}
