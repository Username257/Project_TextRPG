using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_TextRPG
{
    public struct Sprites
    {
        static string textFile = File.ReadAllText(@"..\..\..\sprites.txt");
        string[] lines = textFile.Split(Environment.NewLine);
      
        
        public Sprites()
        {
        }
        public void Test()
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        public void Title()
        {
            int j = 2;
            for (int i = 25; i < 43; i++)
            {
                Console.SetCursorPosition(37, j);
                Console.WriteLine(lines[i], textFile);
                j++;
            }
            Console.SetCursorPosition(0, 60);
        }
        public void TitleButton()
        {
            for (int i = 93; i < 95; i++)
            {
                Console.SetCursorPosition(30, 25);
                Console.WriteLine(lines[i], textFile);
            }
            Console.SetCursorPosition(0, 60);
        }
    }
}
