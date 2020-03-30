using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox text1 = new TextBox();
            text1.Padding = 15;
            text1.BackColor = Console.BackgroundColor = ConsoleColor.Red;
            text1.ForeColor = Console.ForegroundColor = ConsoleColor.Blue;
            text1.Text = "Hello World";
            DisplayText(text1);
            Console.ResetColor();

            TextBox text2 = new TextBox();
            text2.Padding = 20;
            text2.BackColor = Console.BackgroundColor = ConsoleColor.Cyan;
            text2.ForeColor = Console.ForegroundColor = ConsoleColor.Black;
            text2.Text = "Meep";
            DisplayText(text2);

            Console.ReadKey();
        }
        static void DisplayText(TextBox t)
        {
            
            Console.WriteLine(t.Text.PadLeft(t.Padding,' ').PadRight(t.Padding,' '));
        }
    }
}
