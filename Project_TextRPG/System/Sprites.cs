using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Project_TextRPG
{
    public struct Sprites
    {
        static string textFile = File.ReadAllText(@"..\..\..\sprites.txt");
        string[] lines = textFile.Split(Environment.NewLine);
        PlayerState playerState = new PlayerState();

        public Sprites()
        {
        }

        public void Clear()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine(lines[105], textFile);
                
            }

        }
        public void Remove()
        {
            for (int i = 0; i < 23; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine(lines[105], textFile);
                Bar();
            }

        }
        public void Bar()
        {
            Console.SetCursorPosition(5, 16);
            Console.WriteLine($" _|  {playerState.name}  |_");
            Console.SetCursorPosition(0, 17);
            Console.WriteLine(lines[107], textFile);
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
            
        }
        public void TitleButton()
        {
            
            for (int i = 93; i < 94; i++)
            {
                Console.SetCursorPosition(30, 25);
                Console.WriteLine(lines[i], textFile);
            }
           
        }
        public void Potato()
        {

            int j = 2;
            for (int i = 63; i < 73; i++)
            {
                Console.SetCursorPosition(45, j);
                Console.WriteLine(lines[i], textFile);
                j++;
            }
            
        }
        public void SleepyingPotato()
        {

            int j = 2;
            for (int i = 52; i < 62; i++)
            {
                Console.SetCursorPosition(45, j);
                Console.WriteLine(lines[i], textFile);
                j++;
            }
            
        }
        public void SpeechBubbleForPotato()
        {
  
            int j = 2;
            for (int i = 98; i < 104; i++)
            {
                Console.SetCursorPosition(70, j);
                Console.WriteLine(lines[i], textFile);
                j++;
            }
           
        }
        public void Crown()
        {
            int j = 0;
            for (int i = 95; i < 97; i++)
            {
                Console.SetCursorPosition(45, j);
                Console.WriteLine(lines[i], textFile);
                j++;
            }
        }

        public void Fight()
        {
            Remove();
            int j = 4;
            for (int i = 109; i < 120; i++)
            {
                Console.SetCursorPosition(30, j);
                Console.WriteLine(lines[i], textFile);
                j++;
            }
            Console.SetCursorPosition(0, 30);
        }
        public void PlayerSleep()
        {
            int j = 2;
            for (int i = 121; i < 128; i++)
            {
                Console.SetCursorPosition(45, j);
                Console.WriteLine(lines[i], textFile);
                j++;
            }
            Console.SetCursorPosition(0, 30);
        }
        public void PlayerDefault()
        {
            int j = 2;
            for (int i = 129; i < 136; i++)
            {
                Console.SetCursorPosition(45, j);
                Console.WriteLine(lines[i], textFile);
                j++;
            }
            Console.SetCursorPosition(0, 30);
        }
        public void PlayerBigEyed()
        {
            int j = 2;
            for (int i = 137; i < 144; i++)
            {
                Console.SetCursorPosition(45, j);
                Console.WriteLine(lines[i], textFile);
                j++;
            }
            Console.SetCursorPosition(0, 30);
        }

        public List<string> ForName()
        {
            string line = "";
            for (int i = 145; i < 146; i++)
            {
                line = lines[i];
            }

            List<string> words = new List<string>();
            for (int i = 0; i < 47; i++)
            {
                words.Add(line.Split(' ')[i]);
            }

            words = words.Distinct().ToList();
            words.Sort((a, b) => new Random().NextDouble() >= 0.5 ? 1 : -1);
            return words;
        }

        public void Slime(int x, int y)
        {
            for (int i = 44; i < 51; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(lines[i], textFile);
                y++;
            }
            Console.SetCursorPosition(0, 30);
        }
        public void SlimeJump(int x, int y)
        {
            for (int i = 147; i < 154; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(lines[i], textFile);
                y++;
            }
            Console.SetCursorPosition(0, 30);
        }

        public void Walk1(int x, int y)
        {
            for (int i = 1; i < 8; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(lines[i], textFile);
                y++;
            }
            Console.SetCursorPosition(0, 30);
        }
        public void Walk2(int x, int y)
        {
            for (int i = 9; i < 16; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(lines[i], textFile);
                y++;
            }
            Console.SetCursorPosition(0, 30);
        }
    }
}
