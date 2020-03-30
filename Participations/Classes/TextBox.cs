using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class TextBox
    {
        public int Padding { get; set; }

        public ConsoleColor BackColor { get; set; }

        public ConsoleColor ForeColor { get; set; }

        public string Text { get; set; }

        public TextBox()
        {
            Padding = 0;
            BackColor = Console.BackgroundColor = ConsoleColor.White;
            ForeColor = Console.ForegroundColor = ConsoleColor.Black;
            Text = "Hello";
        }

    }
}
