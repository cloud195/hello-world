using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    class Minesweeper
    {
        private string name;
        private int difficulty;
        private string color;
        private Form start;
        private PictureBox picMine;

        public Minesweeper(string n, int d, string c, Form s,)
        {
            name = n;
            difficulty = d;
            start = s;
            color = c;
            picMine.Image = ;
        }

        public void displayMine()
        {
            Form formMine = new Form();
            formMine.Width = 400;
            formMine.Height = 400;
            formMine.Text = "Minesweeper - " + name;
            formMine.Show();
            start.Hide();
        }
    }
}
