using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TextRPG
{
    public class Naming : Scene
    {
        Sprites sprites = new Sprites();
        PlayerState playerState = new PlayerState();
        
        bool goNextScene = false;


        public Naming(Game game) : base(game)
        {
            
        }
        public override void Render()
        {
            sprites.Remove();
        }

        public override void Update()
        {
            

            sprites.PlayerSleep();
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(60, 3);
            Console.WriteLine("쿨");
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(62, 5);
            Console.WriteLine("쿨");
            System.Threading.Thread.Sleep(1000);

            Render();
            sprites.PlayerDefault();
            System.Threading.Thread.Sleep(500);
            Render();
            sprites.PlayerSleep();
            System.Threading.Thread.Sleep(500);
            Render();
            sprites.PlayerDefault();
            System.Threading.Thread.Sleep(1000);
            Render();
            sprites.PlayerBigEyed();

            Console.SetCursorPosition(5, 18);
            Console.WriteLine("일어나보니 이세계다!! 당신의 이름은?");

            
            

            Console.SetCursorPosition(11, 20);
            Console.Write(" ▼");
            Console.SetCursorPosition(6, 21);
            Console.Write("【 이름 짓기 】");


            Console.SetCursorPosition(0, 30);
            

            while (true)
            {
                Console.SetCursorPosition(0, 30);
                ConsoleKeyInfo input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.Z)
                    chooseWord();

                if (goNextScene)
                {
                    game.SayMyName();
                    return;
                }
            }

        }

        public void chooseWord()
        {
            List<string> words = sprites.ForName();
            words.Sort((a, b) => new Random().NextDouble() >= 0.5 ? 1 : -1);

            int i = 0;
            int choice = 0;
            while (true)
            {
                
                Console.SetCursorPosition(40, 21);
                Console.Write("당신의 이름은...　");
                Console.SetCursorPosition(58, 22);
                Console.Write(" 　　　　　　　 ");
                Console.SetCursorPosition(60, 22);
                Console.Write($"〃{words[i]}〃");
                Console.SetCursorPosition(70, 21);
                Console.Write("이다.");
                Console.SetCursorPosition(90, 21);
                Console.Write("【 결정 하기 】");

                Console.SetCursorPosition(0, 30);
                ConsoleKeyInfo input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.RightArrow)
                    choice = 1;
                else if (input.Key == ConsoleKey.LeftArrow)
                    choice = 0;

                if(choice == 0)
                {
                    Console.SetCursorPosition(98, 20);
                    Console.Write("　　　");
                    Console.SetCursorPosition(11, 20);
                    Console.Write(" ▼");
                }
                if (choice == 1)
                {
                    Console.SetCursorPosition(11, 20);
                    Console.Write("　　　");
                    Console.SetCursorPosition(98, 20);
                    Console.Write(" ▼");
                }

                if(choice == 0 && input.Key == ConsoleKey.Z)
                {
                    i++;
                    if (i == 46)
                        i = 0;
                }

                if (choice == 1 && input.Key == ConsoleKey.Z)
                {
                    PlayerState.name = words[i];
                    goNextScene = true;
                    return;
                }

                input = new ConsoleKeyInfo('P', ConsoleKey.P, false, false, false);
            }
        }
    }
}
